using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Target")]
    public GameObject targetPrefab;
    public Transform[] targetSpawn;
    private int targetCount;

    [Header("Timer")]
    public TextMeshProUGUI textUI;
    public float timer = 300;
    private bool isPlaying = true;

    void Start()
    {
        isPlaying = true;
        SpawnTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying) return;

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            EndGame();
        }
        UpdateText();
    }

    void UpdateText()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);

        textUI.text = seconds < 10 ? $"{minutes}:0{seconds}" : $"{minutes}:{seconds}";

        Debug.Log(textUI.text);
    }

    void SpawnTarget()
    {
        if (targetSpawn.Length == 0) return;

        int randomIndex = Random.Range(0, targetSpawn.Length);
        Transform spawnpoint = targetSpawn[randomIndex];
        Instantiate(targetPrefab, spawnpoint.position, Quaternion.identity);
    }

    public void TargetDestroyed()
    {
        targetCount++;
        Debug.Log("alvo destruido");
        SpawnTarget();
    }

    void EndGame()
    {
        isPlaying = false;
        Debug.Log("End Game");
        timer = 0;
    }
}
