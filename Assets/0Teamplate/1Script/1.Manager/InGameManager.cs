using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


[DefaultExecutionOrder(-10)]
public class InGameManager : BaseSingletonScene<InGameManager>
{
    ///////////   variable    //////////

    [SerializeField] Camera     _mainCamera { get;}
    [SerializeField] GameObject _pointer ;
    public           GameObject _spawnTarget;
    GameState                   _gameState = GameState.None;
    Vector3                     _playerPosition;
    Vector3                     _firstEnemyPosition;
    [SerializeField] float      _StartCoolTime = 10;

    public bool _isDragIngPlayer     = false;
    public bool _isOutPlayerSetPanel = false;

    //user game data
    int       _playerID = 0;
    List<int> _playerCharacterDeckID;
    List<int> _platerSkillDeckID;

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

    void MousePointerSpawn() { _pointer = Instantiate(_pointer, Vector3.zero, Quaternion.identity); }

    public void RemoveSpawnTargetToPointerChild(GameObject target)
    {
        Destroy(_spawnTarget);
        _spawnTarget = null;
    }


    public void SetSpawnTargetToPointerChild(GameObject target)
    {
        _spawnTarget                    = Instantiate(target);
        _spawnTarget.transform.position = _pointer.transform.position;
        _spawnTarget.transform.SetParent(_pointer.transform);
    }


    void GetDataFromDataManager()
    {
        Debug.Log(" Get Data from DataManager");
        _playerID              = 0;
        _playerCharacterDeckID = new List<int>() { 1, 2, 3, 4, 5 };
        _platerSkillDeckID     = new List<int>() { 1, 2 };
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
    public void PlayerSetMode() { PlayerSetStartEvent?.Invoke(); }
    public void CombatStart()   { CombatStartEvent?.Invoke(); }
    public void CombatMode()    { CombatModeEvent?.Invoke(); }
    public void Pause()         { PauseEvent?.Invoke(); }
    public void Manu()          { ManuEvent?.Invoke(); }
    public void GameOver()      { GameOverEvent?.Invoke(); }


    protected override void AwakeFunction()  { }
}

public enum GameState
{
    None, StartGame, PlayerSetStart, PlayerSetMode, CombatStart,
    CombatMode, Pause, Manu, GameOver,
}