using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button quitButton;
    public Button playButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playButton.onClick.AddListener(OnClickPlay);
        quitButton.onClick.AddListener(OnClickQuit);
    }

    void OnClickPlay()
    {
        SceneManager.LoadScene("MainScene");
    }

    void OnClickQuit()
    {
        Application.Quit();
    }

       
}
