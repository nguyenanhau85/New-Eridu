using UnityEngine;
using UnityEngine.UI;

public class ButtonQuit: MonoBehaviour
{
    Button _quitButton;

    private void Start()
    {
        _quitButton = GetComponent<Button>();
        _quitButton.onClick.AddListener(QuitGame);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting the game...");
        Application.Quit(); // Thoat game khi build

        #if UNITY_EDITOR
        // Neu đang chay trong Editor thi dung Play Mode
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
