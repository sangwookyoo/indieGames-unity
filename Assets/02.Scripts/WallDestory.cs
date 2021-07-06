using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestory : MonoBehaviour
{
    private GameManager gm;
    public GameObject Wall;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("num") == 1)
        {
            Destroy(Wall);
        }
    }
}