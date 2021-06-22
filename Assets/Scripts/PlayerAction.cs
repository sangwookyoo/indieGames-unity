using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerAction : MonoBehaviour
{
    float h;
    float v;
    public float speed;
    bool isHorizonMove;


    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //movw Value
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        //Check Button Bown & Up
        bool hDown = Input.GetButtonDown("Horizontal");
        bool vDown = Input.GetButtonDown("Vertical");
        bool hUp = Input.GetButtonUp("Horizontal");
        bool vUp = Input.GetButtonUp("Vertical");

        //Check Horizontal Move
        if (hDown || vUp)
            isHorizonMove = true;
        else if (vDown ||hUp)
            isHorizonMove = false;

        ////Movw
        Vector2 moveVec= isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        transform.Translate(moveVec *speed* Time.deltaTime);
      

    }
}
