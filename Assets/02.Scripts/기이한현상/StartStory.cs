using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStory : MonoBehaviour
{
    private PlayerAction thePlayer;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerAction>();
        thePlayer.transform.position = this.transform.position;
    }
}