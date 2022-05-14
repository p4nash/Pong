using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScipt : PlayerScript
{
    public GameObject ball;
    float paddleHeight;

    [SerializeField]
    bool shouldDetectBallLeft;

    // Start is called before the first frame update
    void Start()
    {
        paddleHeight = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (ball.GetComponent<Rigidbody2D>().velocity.x > 0 && !shouldDetectBallLeft
            || ball.GetComponent<Rigidbody2D>().velocity.x < 0 && shouldDetectBallLeft)
        {
            if (ball.transform.position.y > transform.position.y + paddleHeight / 2)
            {
                MoveUp();
            }
            else if (ball.transform.position.y < transform.position.y - paddleHeight / 2)
            {
                MoveDown();
            }
            else
            {
                StayStationary();
            }

            rigidBody.velocity = velocity;
        }
    }
}
