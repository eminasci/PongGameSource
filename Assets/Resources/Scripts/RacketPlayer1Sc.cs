using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer1Sc : MonoBehaviour
{
    public float movenmentSpeed;
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical1");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v )*movenmentSpeed; 
    }
   
} 
