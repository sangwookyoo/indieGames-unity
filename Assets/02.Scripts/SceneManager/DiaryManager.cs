using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryManager : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("DiaryCount") == 1)
            audioSource.Play();
        if (PlayerPrefs.GetInt("DiaryCount") == 2)
            audioSource.Play();

    }
}
