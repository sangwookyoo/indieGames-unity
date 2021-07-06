using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Roof : MonoBehaviour
{
    public AudioClip EffectSound;
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Roof")
        {
            audioSource.PlayOneShot(EffectSound);
        }
    }
}
