using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum PlayerState
{
    move,
    inspect,
    cinematic
}
public class GameManager : MonoBehaviour
{
    public static GameManager _manager;
    public InspectItem inspectItem;
    public PlayerState state;

    void Start()
    {
        _manager = this;
    }
}