using UnityEngine;
using System.Collections;

public class MoveScene : MonoBehaviour
{
    void Update()
    {
        transform.rotation *= Quaternion.Euler(Input.acceleration.y/6, -Input.acceleration.x/3, 0);
    }
}
