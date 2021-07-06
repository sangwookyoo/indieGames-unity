using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkWindow : MonoBehaviour
{

    
    public GameObject Talk_;
    PlayerAction playeraction = GameObject.Find("Player").GetComponent<PlayerAction>();
    int speed_;

    private void Update()
    {
        //gameObject.GetComponent<PlayerAction>().enabled = false;
        //PlayerAction playeraction = GameObject.Find("Player").GetComponent<PlayerAction>();
        playeraction.speed = 0;
        if (Input.GetKeyDown("space"))
        {
            Talk_.SetActive(false);
            if(Talk_.activeSelf == false)
            {
                playeraction.speed = 3;
            }
            
        }

    }

}
