using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnTriggerEnter(Collider obj)
    {
        Debug.Log("Collision");
        Destroy(obj);
    }
}
