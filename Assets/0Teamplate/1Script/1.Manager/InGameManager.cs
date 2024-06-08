using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


[DefaultExecutionOrder(-10)]
public class InGameManager : BaseSingletonScene<InGameManager>
{
    ///////////   variable    //////////

    private                                                                                   GameState _gameState = GameState.None;
    private                                                                                   Vector3   _playerPosition;
    private                                                                                   Vector3   _firstEnemyPosition;
    [SerializeField] float     _StartCoolTime = 10;
    
         
    //user game data
    private int _playerID = 0;
    List<int>   _playerCharacterDeck;
    List<int>   _platerDeck;

    //////////   property   //////////
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

            _gameState          = value;
        }
    }

    public Vector3 PlayerPosition     { get { return _playerPosition; }     set { _playerPosition     = value; } }
    public Vector3 FirstEnemyPosition { get { return _firstEnemyPosition; } set { _firstEnemyPosition = value; } }
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
    void Start() { StartCoroutine(StartCoolTime()); }
    //コルーチンで10秒待つ
    IEnumerator StartCoolTime()
    {
        yield return new WaitForSeconds(_StartCoolTime);
        GameStateP = GameState.StartGame;
    }
    public void StartGame()
    {
        UIManager.Instance.ShowUI(UITypeClass.EnumUIType.Deck);
        PlayerStarted?.Invoke();
    }
    public void PlayerSetStart() { PlayerSetStartEvent?.Invoke(); }
    public void PlayerSetMode()  { PlayerSetStartEvent?.Invoke(); }
    public void CombatStart()    { CombatStartEvent?.Invoke(); }
    public void CombatMode()     { CombatModeEvent?.Invoke(); }
    public void Pause()          { PauseEvent?.Invoke(); }
    public void Manu()           { ManuEvent?.Invoke(); }
    public void GameOver()       { GameOverEvent?.Invoke(); }


    protected override void AwakeFunction()  { }
}

public enum GameState
{
    None, StartGame, PlayerSetStart, PlayerSetMode, CombatStart,
    CombatMode, Pause, Manu, GameOver,
}