using System;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class ButtonHomeScreen : MonoBehaviour
{
    Button _button;
    public static event Action OnHomeScreen;
    void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() => OnHomeScreen?.Invoke());
    }
}