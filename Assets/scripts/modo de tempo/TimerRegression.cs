using TMPro;
using UnityEngine;

public class TimerRegression : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    public float timer = 300;
    private bool isCounting = true;
    void Start()
    {
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if(!isCounting) return;

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            isCounting = false;
            timer = 0;

        }
        UpdateText();
    }

    void UpdateText()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);

        textUI.text = seconds < 10 ? $"{minutes}:0{seconds}" : $"{minutes}:{seconds}";

        //if (seconds < 10)
        //{
        //    textUI.text = $"{minutes}:0{seconds}";
        //}
        //else
        //{
        //    textUI.text = $"{minutes}:0{seconds}";
        //}
        Debug.Log(textUI.text);
    }
}
