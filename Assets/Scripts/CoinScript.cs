using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    
    public AudioSource CoinPickup;
    public AudioClip SoundEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            GetBumped();

            CoinPickup.PlayOneShot(SoundEffect);

            Destroy(gameObject, SoundEffect.length);
        }
        
    }

    public void GetBumped()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
    }
}