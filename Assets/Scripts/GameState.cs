using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField]
    private State _state;

    [SerializeField]
    private AudioSource _ostGame, _ostUI;

    public static GameState Singleton;

    private Player _player;

    public State CurrentState { get => _state; }

    private void Awake()
    {
        _player = FindObjectOfType<Player>();
        Singleton = this;
    }

    public void SetUIState()
    {
        _state = State.InUI;

        _player.GameInUIState();
        _ostUI.volume = 1f;
        _ostGame.volume = 0f;
    }

    public void SetGameState()
    {
        _state = State.InGame;

        _player.GameInGameState();
        _ostUI.volume = 0f;
        _ostGame.volume = 1f;
    }

    public enum State
    {
        InGame,
        InUI
    }
}
