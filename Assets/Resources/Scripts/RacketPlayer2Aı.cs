using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2Aı : MonoBehaviour
{
    public float movenmentSpeed;

    public GameObject ball;

    private void FixedUpdate()
    {
        if (Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 30){
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movenmentSpeed;

            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movenmentSpeed;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
    
}
