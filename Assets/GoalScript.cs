using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public string goalie;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if(collision.gameObject.name == "Ball")
        {
            //call the game manager to handle score
            gameManager.HandleScore(goalie);
        }
    }
}
