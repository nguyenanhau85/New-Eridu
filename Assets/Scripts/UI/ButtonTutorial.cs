using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonTutorial: MonoBehaviour
{
    Button _button;
    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() => GameStateManager.SetState(GameState.Tutorial));
    }
}

