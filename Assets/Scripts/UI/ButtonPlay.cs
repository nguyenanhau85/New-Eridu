﻿using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonPlay : MonoBehaviour
{
    Button _button;
    void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() => GameStateManager.SetState(GameState.Playing));
    }
}
