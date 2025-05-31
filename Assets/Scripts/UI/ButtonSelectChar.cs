using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonSelectChar: MonoBehaviour
{
    Button _button;
    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() => GameStateManager.SetState(GameState.Home));
    }
}
