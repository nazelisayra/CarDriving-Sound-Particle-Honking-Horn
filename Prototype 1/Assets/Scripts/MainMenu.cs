using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Prototype 1");
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
