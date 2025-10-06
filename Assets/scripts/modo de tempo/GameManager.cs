using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Target")]
    public GameObject targetPrefab;
    public Transform[] targetSpawn;
    public float targetCount;
    public AudioClip targetClip;
    public AudioSource targetClip2;

    [Header("Timer")]
    public TextMeshProUGUI textUI;
    private float timer = 0;
    private float timerReset = 60;
    private bool isPlaying = false;

    [Header("Accuracy")]
    public TextMeshProUGUI textAccuracy;
    public ControllerShooter controllerShooter;
    public ControllerShooter controllerShooter2;

    public GameObject win;
    public GameObject counter;

    public void StartCounter()
    {
        timer = timerReset;
        controllerShooter.shotCount = 0;
        controllerShooter2.shotCount = 0;
        targetCount = 0;
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

        float accuracy = (targetCount /( controllerShooter.shotCount + controllerShooter2.shotCount)) * 100;

        textAccuracy.text = $"Accuracy: {accuracy.ToString("F0")}";
        Debug.Log(accuracy);
        //Debug.Log(targetCount);
        //Debug.Log(controllerShooter.shotCount);

        //Debug.Log(textUI.text);
    }

    void SpawnTarget()
    {
        if (targetSpawn.Length == 0) return;

        int randomIndex = Random.Range(0, targetSpawn.Length);
        Transform spawnpoint = targetSpawn[randomIndex];
        Instantiate(targetPrefab, spawnpoint.position, Quaternion.identity);
        Debug.Log("alvo spawnado");
        targetClip2.PlayOneShot(targetClip);
    }

    public void TargetDestroyed()
    {
        if (!isPlaying) return;
        targetCount++;
        //Debug.Log(targetCount);
        Debug.Log("alvo destruido");
        SpawnTarget();
    }

    void EndGame()
    {
        isPlaying = false;
        Debug.Log("End Game");
        timer = 0;
        counter.SetActive(false);
        win.SetActive(true);
    }
}
