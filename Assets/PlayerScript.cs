using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public string up, down;

    public Rigidbody2D rigidBody;

    Vector2 velocity = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start of player called");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            //move the player up
            //rigidBody.velocity = moving upwards
            Debug.Log("up key pressed");
            velocity = new Vector2(0, 5);
        }
        else if (Input.GetKey(down))
        {
            //move the player down
            //rigidBody.velocity = moving downwards
            Debug.Log("down key pressed");
            velocity = new Vector2(0, -5);
        }
        else
        {
            //don't move the player
            //rigidBody.velocity = zero (don't move)
            velocity = new Vector2(0, 0);
        }

        rigidBody.velocity = velocity;
    }
}
