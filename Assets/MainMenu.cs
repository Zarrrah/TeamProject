using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button optionsButton;
    public Button quitButton;


    // Use this for initialization
    void Start()
    {
        Button btn = playButton.GetComponent<Button>();
        btn.onClick.AddListener(PlayButtonOnClick);
        btn = optionsButton.GetComponent<Button>();
        btn.onClick.AddListener(OptionsButtonOnClick);
        btn = quitButton.GetComponent<Button>();
        btn.onClick.AddListener(QuitButtonOnClick);
    }
    void PlayButtonOnClick()
    {
        SceneManager.LoadScene("Lobby");
    }
    void OptionsButtonOnClick()
    {

    }
    void QuitButtonOnClick()
    {
        Application.Quit();
    }


}
