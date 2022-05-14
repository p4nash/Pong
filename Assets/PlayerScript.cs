using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private string up, down;

    public Rigidbody2D rigidBody;

    protected Vector2 velocity = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start of player called");
    }

    protected void MoveUp()
    {
        velocity = new Vector2(0, 5);
    }

    protected void MoveDown()
    {
        velocity = new Vector2(0, -5);
    }

    protected void StayStationary()
    {
        velocity = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            //move the player up
            //rigidBody.velocity = moving upwards
            Debug.Log("up key pressed");
            MoveUp();
        }
        else if (Input.GetKey(down))
        {
            //move the player down
            //rigidBody.velocity = moving downwards
            Debug.Log("down key pressed");
            MoveDown();
        }
        else
        {
            //don't move the player
            //rigidBody.velocity = zero (don't move)
            StayStationary();
        }

        rigidBody.velocity = velocity;
    }
}
