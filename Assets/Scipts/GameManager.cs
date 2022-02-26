using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float ScaleRate;
    [SerializeField] GameObject Projectile;
    // Start is called before the first frame update
    void Start()
    {
        ScaleRate = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
            if(Projectile != null)
            {
                Projectile.transform.localScale = new Vector3(ScaleRate,ScaleRate,ScaleRate);
                if(ScaleRate > 0)
                {
                    ScaleRate -= 0.01f;
                }
                else
                {
                    ScaleRate = 0.4f;
                }
            }
    }
}
