using TMPro;
using UnityEngine;

public class winManager : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI textMeshPro;
    public GameObject menu;
    public GameObject win;

    public void backMenu()
    {
        win.SetActive(false);
        menu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = "Destroyed Targets: " + gameManager.targetCount.ToString();
    }
}
