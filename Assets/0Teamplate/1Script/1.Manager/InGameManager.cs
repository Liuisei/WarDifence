using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


[DefaultExecutionOrder(-10)]
public class InGameManager : BaseSingletonScene<InGameManager>
{
    ///////////   variable    //////////

    public           Camera     _mainCamera ;
    [SerializeField] GameObject _pointer ;
    public           GameObject _spawnTarget;
    GameState                   _gameState = GameState.None;
    Vector3                     _playerPosition;
    Vector3                     _firstEnemyPosition;
    public           int        _inGamePoint   = 0;
    [SerializeField] float      _StartCoolTime = 10;

    public bool _isDragIngPlayer     = false;
    public bool _isOutPlayerSetPanel = false;

    //user game data
    int       _playerID = 0;
    List<int> _playerCharacterDeckID;
    List<int> _playerSkillDeckID;

    //enemy data
    List<int>   _enemyDeckID;


    //////////   property   //////////
    /// 
    public          GameState GameStateP
    {
        get { return _gameState; }
        private set
        {
            switch (value)
            {
                case GameState.StartGame:
                    StartGame();
                    break;
                case GameState.PlayerSetStart:
                    PlayerSetStart();
                    break;
                case GameState.PlayerSetMode:
                    PlayerSetMode();
                    break;
                case GameState.PlayerSetEndCoolTime:
                    PlayerSetEndCoolTime();
                    break;
                case GameState.CombatStart:
                    CombatStart();
                    break;
                case GameState.CombatMode:
                    CombatMode();
                    break;
                case GameState.Pause:
                    Pause();
                    break;
                case GameState.Manu:
                    Manu();
                    break;
                case GameState.GameOver:
                    GameOver();
                    break;
            }

            Debug.Log(value);
            _gameState          = value;
        }
    }

    public int     PlayerID           { get { return _playerID; }           private set { _playerID           = value; } }
    public Vector3 PlayerPosition     { get { return _playerPosition; }     private set { _playerPosition     = value; } }
    public Vector3 FirstEnemyPosition { get { return _firstEnemyPosition; } private set { _firstEnemyPosition = value; } }

    ///////////  action  //////////

    public event Action PlayerStarted;
    public event Action PlayerSetStartEvent;
    public event Action PlayerSetModeEvent;
    public event Action PlayerSetEndCoolTimeEvent;
    public event Action CombatStartEvent;
    public event Action CombatModeEvent;
    public event Action PauseEvent;
    public event Action ManuEvent;
    public event Action GameOverEvent;


    ///////////   function    //////////
    void Start()
    {
        MousePointerSpawn();
        GetDataFromDataManager();
        StartCoroutine(ChangeStateCoolTime(GameState.StartGame, _StartCoolTime));
    }

    /// <summary> Start時に マウス追跡のPointerを生成する</summary>///
    void MousePointerSpawn() { _pointer = Instantiate(_pointer, Vector3.zero, Quaternion.identity); }

    /// <summary>カードをドラッグして離したときに呼ばれる関数</summary>///
    public void CardDragEnd()
    {
        if (_isOutPlayerSetPanel == true) { _spawnTarget.transform.SetParent(null); }
        else
        {
            Destroy(_spawnTarget);
            _spawnTarget = null;
        }
    }

    /// <summary>
    /// カードを選択したら呼ばれる関数
    /// target:選択されたカードのGameObjectを生成して、Pointerの子にする
    /// </summary>
    /// <param name="target">選択されたカードのGameObject</param>
    public void SetSpawnTargetToPointerChild(GameObject target)
    {
        _spawnTarget                    = Instantiate(target, _pointer.transform, true);
        _spawnTarget.transform.position = _pointer.transform.position;
    }

    /// <summary>
    /// データの初期化
    /// </summary>
    void GetDataFromDataManager()
    {
        Debug.Log(" Get Data from DataManager");
        _playerID              = 0;
        _playerCharacterDeckID = new List<int>() { 1, 2, 3, 4, 5 };
        _playerSkillDeckID     = new List<int>() { 1, 2 };
    }

    IEnumerator ChangeStateCoolTime(GameState  state , float time)
    {
        yield return new WaitForSeconds(time);
        GameStateP = state;
    }
    public void StartGame()
    {
        StartCoroutine( ChangeStateCoolTime(GameState.PlayerSetStart, 1) );
        PlayerStarted?.Invoke();
    }
    public void PlayerSetStart()
    {
        UIManager.Instance.ShowUI(UITypeClass.EnumUIType.PlayerSet);
        PlayerSetStartEvent?.Invoke();
    }
    public void PlayerSetMode()
    {
        PlayerSetModeEvent?.Invoke();
    }
    public void PlayerSetEndCoolTime() { PlayerSetEndCoolTimeEvent?.Invoke(); }
    public void CombatStart()          { CombatStartEvent?.Invoke(); }
    public void CombatMode()           { CombatModeEvent?.Invoke(); }
    public void Pause()                { PauseEvent?.Invoke(); }
    public void Manu()                 { ManuEvent?.Invoke(); }
    public void GameOver()             { GameOverEvent?.Invoke(); }


    protected override void AwakeFunction()  { }
}

public enum GameState
{
    None, StartGame, PlayerSetStart, PlayerSetMode, PlayerSetEndCoolTime,
    CombatStart, CombatMode, Pause, Manu, GameOver,
}