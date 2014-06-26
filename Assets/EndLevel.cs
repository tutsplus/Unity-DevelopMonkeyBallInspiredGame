using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour
{
    public GameObject complete;
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        audio.Play();
        Invoke("Restart", 2);
        GameObject alert = Instantiate(complete, new Vector3(0.5f, 0.5f, 0), transform.rotation) as GameObject;
        Destroy(player.rigidbody);
    }

    void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
