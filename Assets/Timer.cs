using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
    public GUIText timeText;

    void Start()
    {
        InvokeRepeating("ReduceTime", 1, 1);
    }

    void ReduceTime()
    {
        int currentTime = int.Parse(timeText.text) - 1;
        timeText.text = currentTime.ToString();

        if (currentTime == 0)
        {
            audio.Play();
            Invoke("Reload", 1.59f);
            Destroy(timeText);
        }
    }

    void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
