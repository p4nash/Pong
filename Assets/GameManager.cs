using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        InitializeBall();
    }

    int player1Score, player2Score = 0;
    public Text score;

    public void HandleScore(string goalie)
    {
        //logic for handling score
        Debug.Log("Game manager handles score! " + goalie);

        if(goalie == "Player 1")
        {
            player2Score++;
        }
        else if (goalie == "Player 2")
        {
            player1Score++;
        }

        score.text = player1Score + " : " + player2Score;

        InitializeBall();
            
        //if player 1 score == 10, then player 1 wins
        //reflect in the UI
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitBeforeMovingBall()
    {
        float waitTime = 3f;
        float timer = 0;

        while(timer < waitTime)
        {
            yield return new WaitForSeconds(1);
            timer++;
        }

        MoveBall();
    }

    void InitializeBall()
    {
        ball.transform.position = Vector3.zero;
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        //call coroutine, wait x seconds before moving our ball
        StartCoroutine(WaitBeforeMovingBall());
    }

    void MoveBall()
    {
        //float meaning decimal. it can be 0.2 or 0.7f
        float xRandom = Random.value;
        float yRandom = Random.value;

        float xVelocity = 0;
        float yVelocity = 0;

        //randomize x and y velocity based on a coin toss
        //if coin toss is heads move the ball left
        if (xRandom < 0.5f)
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
}
