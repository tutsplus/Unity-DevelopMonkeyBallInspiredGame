using UnityEngine;
using System.Collections;

public class Lose : MonoBehaviour
{
    void OnCollisionEnter()
    {
        audio.Play();
        Invoke("Reload", 1.59f);
    }

    void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
