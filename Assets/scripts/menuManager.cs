using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject menu;
    public GameObject counter;
    public GameObject menuMusic;
    public GameObject stageMusic;

    public void Awake()
    {
        counter.SetActive(false);
        menu.SetActive(true);

        menuMusic.SetActive(true);
        stageMusic.SetActive(false);
    }

    // Função para iniciar o jogo
    public void StartGame()
    {
        menu.SetActive(false);

        menuMusic.SetActive(false);
        stageMusic.SetActive(true);

        counter.SetActive(true);
        gameManager.StartCounter();
    }

    // Função para sair
    public void QuitGame()
    {

        Application.Quit();
    }
    
}
