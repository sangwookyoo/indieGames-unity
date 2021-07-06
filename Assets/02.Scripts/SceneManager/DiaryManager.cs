using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryManager : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject Wall;
    public AudioClip EffectSound;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("DiaryCount") == 2)
        {
            Destroy(Wall);
            audioSource.PlayOneShot(EffectSound,0.7f);
        }
        if (PlayerPrefs.GetInt("DiaryCount") == 3)
        {
            audioSource.Play();
        }

    }
}
