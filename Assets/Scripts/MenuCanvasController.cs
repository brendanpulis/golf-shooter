using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCanvasController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject LevelSelect;
    public GameObject Rules;

    private void OnEnable()
    {
        NavigateToMainMenu();
    }

    public void LaunchLevel(string levelName)
    {
        SceneManager.LoadSceneAsync(levelName);
    }

    public void NavigateToMainMenu()
    {
        LevelSelect.SetActive(false);
        Rules.SetActive(false);

        MainMenu.SetActive(true);
    }

    public void NavigateToLevelSelect()
    {
        MainMenu.SetActive(false);
        Rules.SetActive(false);

        LevelSelect.SetActive(true);
    }

    public void NavigateToRules()
    {
        MainMenu.SetActive(false);
        LevelSelect.SetActive(false);

        Rules.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LaunchWeblink(string link)
    {
        Application.OpenURL(link);
    }
}
