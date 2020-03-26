using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnumsSwitches : MonoBehaviour
{
    public UnityEvent idleEvent, walkEvent, runEvent, jumpEvent;
    public UnityEvent startingEvent, playingEvent, inStoreEvent, pausingEvent, endingEvent;
    public UnityEvent primaryEvent, SecondaryEvent, MeleeEvent;

    public enum GameStates
    {
        Starting,
        Playing,
        InStore,
        Pausing,
        Ending,
    }

    public enum WeaponStates
    {
        Primary,
        Secondary,
        Melee,
    }
    public WeaponStates currentWeaponState;
    
    public GameStates currentGameState;

    public enum PlayerStates
    {
        Idle,
        Walk,
        Run,
        Jump,
    }    
    
    public PlayerStates currentPlayerState;

    public void ChangeStateToPlaying ()
    {
        currentGameState = GameStates.Playing;
    }

    public void ChangeStateToPausing ()
    {
        currentGameState = GameStates.Pausing;
    }

    public void ChangeStateInStore ()
    {
        currentGameState = GameStates.InStore;
    }

    void Update()
    {
        switch (currentPlayerState)
        {
            case PlayerStates.Idle:
                idleEvent.Invoke();
                break;
            case PlayerStates.Walk:
                walkEvent.Invoke();
                break;
            case PlayerStates.Run:
                runEvent.Invoke();
                break;
            case PlayerStates.Jump:
                jumpEvent.Invoke();
                break;
            default:
                print("I am any");
                break;
        }
        
        switch (currentGameState)
        {
            case GameStates.Starting:
                startingEvent.Invoke();
                break;
            case GameStates.Playing:
                playingEvent.Invoke();
                break;
            case GameStates.InStore:
                inStoreEvent.Invoke();
                break;
            case GameStates.Pausing:
                pausingEvent.Invoke();
                break;
            case GameStates.Ending:
                endingEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        switch (currentWeaponState)
        {
            case WeaponStates.Primary:
                primaryEvent.Invoke();
                break;
            case WeaponStates.Secondary:
                SecondaryEvent.Invoke();
                break;
            case WeaponStates.Melee:
                MeleeEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
