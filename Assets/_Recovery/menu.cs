using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject mainMenu;
    public GameObject carga;

    public Transition transition;

    public void OpenOptionsPanel()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void OpenMainMenuPanel()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void PlayGame()
    {
        //SceneManager.LoadScene("inicio");
        carga.SetActive(true);
        transition.Playanimacon();
        mainMenu.SetActive(false);

    }
}
