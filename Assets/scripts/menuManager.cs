using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject menu;
    public GameObject counter;

    public void Awake()
    {
        counter.SetActive(false);
        menu.SetActive(true);
    }

    // Fun��o para iniciar o jogo
    public void StartGame()
    {
        menu.SetActive(false);
        counter.SetActive(true);
        gameManager.StartCounter();
    }

    // Fun��o para sair
    public void QuitGame()
    {

        Application.Quit();
    }
    
}
