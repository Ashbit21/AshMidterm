using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class MeowAudio : MonoBehaviour
{
        public AudioSource Meow;
        public AudioClip SoundEffect;

    // Update is called once per frame
    void Update()
    {
       

        if (Keyboard.current.mKey.isPressed)
        {
            Meow.PlayOneShot(SoundEffect);
        }
    }
}
