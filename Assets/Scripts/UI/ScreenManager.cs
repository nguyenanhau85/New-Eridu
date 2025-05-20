using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public GameObject homeScreen, gameScreen, pauseScreen, levelUpScreen, endScreen, leaderboardScreen, mainMenu;

    void Awake()
    {
        mainMenu.SetActive(true);
        homeScreen.SetActive(false);
        gameScreen.SetActive(false);
        pauseScreen.SetActive(false);
        levelUpScreen.SetActive(false);
        endScreen.SetActive(false);
        leaderboardScreen.SetActive(false);
    }

    void Start()
    {
        GameStateManager.OnMainMenu += ShowMainMenuScreen;
        GameStateManager.OnPlaying += ShowGameScreen;
        GameStateManager.OnGameOver += ShowEndScreen;
        GameStateManager.OnHome += ShowHomeScreen;
        ButtonPause.OnPauseButtonClicked += ShowPauseScreen;
        ButtonResume.OnResumeButtonClicked += ShowGameScreen;
        ExperienceSystem.OnLevelUp += ShowLevelUpScreen;
        LevelUpChoiceUI.UpgradeChosen += ShowGameScreen;
        GameStateManager.OnLeaderboard += ShowLeaderboard;
    }

    void OnDestroy()
    {
        GameStateManager.OnPlaying -= ShowGameScreen;
        GameStateManager.OnGameOver -= ShowEndScreen;
        GameStateManager.OnHome -= ShowHomeScreen;
        ButtonPause.OnPauseButtonClicked -= ShowPauseScreen;
        ButtonResume.OnResumeButtonClicked -= ShowGameScreen;
        ExperienceSystem.OnLevelUp -= ShowLevelUpScreen;
        LevelUpChoiceUI.UpgradeChosen -= ShowGameScreen;
        GameStateManager.OnLeaderboard -= ShowLeaderboard;
    }

    void ShowMainMenuScreen()
    {
        homeScreen.SetActive(false);
        gameScreen.SetActive(false);
        endScreen.SetActive(false);
        leaderboardScreen.SetActive(false);
        mainMenu.SetActive(true);
    }

    void ShowGameScreen()
    {
        homeScreen.SetActive(false);
        pauseScreen.SetActive(false);
        levelUpScreen.SetActive(false);
        gameScreen.SetActive(true);
    }

    void ShowEndScreen()
    {
        gameScreen.SetActive(false);
        endScreen.SetActive(true);
    }

    void ShowHomeScreen()
    {
        mainMenu.SetActive(false);
        homeScreen.SetActive(true);
        endScreen.SetActive(false);
        leaderboardScreen.SetActive(false);
    }

    void ShowPauseScreen()
    {
        gameScreen.SetActive(false);
        pauseScreen.SetActive(true);
    }

    void ShowLevelUpScreen(int _)
    {
        gameScreen.SetActive(false);
        levelUpScreen.SetActive(true);
    }

    void ShowLeaderboard()
    {
        mainMenu.SetActive(false);
        homeScreen.SetActive(false);
        endScreen.SetActive(false);
        leaderboardScreen.SetActive(true);
    }
}
