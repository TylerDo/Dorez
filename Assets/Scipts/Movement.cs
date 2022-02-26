using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float Speed;//Movement speed multiplier
    Rigidbody2D Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();//Grab rigidbody at start
    }

    // Update is called once per frame
    // We need to do this in update since we want to check each frame
    void Update()
    {
        CheckMovement(); 
    }

    private void CheckMovement()
    {
        float move = 0;
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))//Horizontal
        {
            //Get Axis will get x, y, or z positions
            move = Input.GetAxisRaw("Horizontal");
            Player.velocity = new Vector2(move * Speed, 0);
        }
        else if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))//Vertical
        {
            move = Input.GetAxisRaw("Vertical");
            Player.velocity = new Vector2(0, move * Speed);
        }
    }
}
