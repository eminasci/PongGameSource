using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name=="PlayerRacket1"|| collision.gameObject.name=="PlayerRacket2" )
        {
            this.racketSound.Play();
        }
        else
        {
            this.wallSound.Play();
        }
    }
}
