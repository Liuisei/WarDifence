using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DefaultExecutionOrder(-10)]
public class InGameManager : BaseSingletonScene<InGameManager>
{
    ///////////   variable    //////////

    private          GameState _gameState;
    private          Vector3   _playerPosition;
    private          Vector3   _firstEnemyPosition;
    [SerializeField] float     _coolTime;


    //////////   property   //////////
    public          GameState GameStateP
    {
        get { return _gameState; }
        set
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


    
    ///////////   function    //////////


    void Start()
    {
        _gameState = GameState.StartGame; 
    }

    //コルーチンで10秒待つ
    IEnumerator StartCoolTime()
    {
        yield return new WaitForSeconds(_coolTime);
    }


    public void StartGame()
    {
        StartCoroutine(StartCoolTime());
    }
    public void PlayerSetStart() { }
    public void PlayerSetMode()  { }
    public void CombatStart()    { }
    public void CombatMode()     { }
    public void Pause()          { }
    public void Manu()           { }
    public void GameOver()       { }

    protected override void AwakeFunction()  { }
}
public enum GameState
{
    StartGame, PlayerSetStart, PlayerSetMode, CombatStart, CombatMode,
    Pause, Manu, GameOver,
}