using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollossionController : MonoBehaviour
{
    public BallMovement ballMovenment;
    public ScoreController scoreController;
    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketheight = c.collider.bounds.size.y;
        float x;
        if (c.gameObject.name=="PlayerRacket1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        float y = (ballPosition.y - racketPosition.y) / racketheight;
        this.ballMovenment.IncreaseHitCounter();
        this.ballMovenment.MoveBall(new Vector2 (x, y));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PlayerRacket1" || collision.gameObject.name == "PlayerRacket2")
        {
            this.BounceFromRacket(collision);
        }
        else if (collision.gameObject.name == "WallLeft")
        {
            this.scoreController.GoalPlayer2();
            StartCoroutine(this.ballMovenment.StartBall(true));
           
        
        }
        else if (collision.gameObject.name == "WallRight")
        {
           
            this.scoreController.GoalPlayer1();
            StartCoroutine(this.ballMovenment.StartBall(false));
        }
    }
}
