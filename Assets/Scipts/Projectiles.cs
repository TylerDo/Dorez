using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public GameObject Projectile;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) == true)
        {
            Destroy(Instantiate(Projectile, transform.position, Quaternion.identity), 3f);
        }
    }
}
