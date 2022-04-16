using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        //float meaning decimal. it can be 0.2 or 0.7f
        float xRandom = Random.value;
        float yRandom = Random.value;

        float xVelocity = 0;
        float yVelocity = 0;

        //randomize x and y velocity based on a coin toss
        //if coin toss is heads move the ball left
        if(xRandom < 0.5f)
        {
            //set the x velocity to negative
            xVelocity = -200f;
        }
        //else if coin toss is tails, move the ball right
        else
        {
            xVelocity = 200f;
        }


        //similarly for moving the ball in y direction, use a coin toss
        if (yRandom < 0.5f)
        {
            yVelocity = -200f;
        }
        else
        {
            yVelocity = 200f;
        }
        //-------------------------------------------------------


        //ball is initialized with a random force    
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(xVelocity, yVelocity));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
