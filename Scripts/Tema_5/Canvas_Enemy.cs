using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Enemy : MonoBehaviour
{
    void Update()
    {
        transform.LookAt(Camera.main.transform.position);
    }
}
