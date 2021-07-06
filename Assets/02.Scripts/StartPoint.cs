using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public string startPoint;
    private PlayerAction thePlayer;

    public string startPoint2;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerAction>();

        if (startPoint == thePlayer.preMapname || startPoint2 == thePlayer.preMapname)
        {
            thePlayer.transform.position = this.transform.position;

        }
    }
}