using System;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class ButtonHomeScreen : MonoBehaviour
{
    Button _button;
    void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() => GameStateManager.SetState(GameState.MainMenu));
    }
}