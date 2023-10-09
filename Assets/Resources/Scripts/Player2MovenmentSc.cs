using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2MovenmentSc : MonoBehaviour
{

    public float movenmentSpeed;
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movenmentSpeed;
    }
}
