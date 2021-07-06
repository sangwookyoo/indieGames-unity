using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Vector3 RightVec;
    Vector3 LeftVec;
    Vector3 ForwardVec;
    Vector3 BackVec;

    public GameObject Panel_;
    public GameObject Button_;
    RaycastHit2D rayHit;
    void Start()
    {
        RightVec = Vector3.right;
        LeftVec = Vector3.left;
        ForwardVec = Vector3.up;
        BackVec = Vector3.down;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(transform.position, RightVec * 3f, new Color(0, 1, 0));
        //Debug.DrawRay(transform.position, LeftVec * 3f, new Color(0, 1, 0));
        //Debug.DrawRay(transform.position, ForwardVec * 3f, new Color(0, 1, 0));
        Debug.DrawRay(transform.position, BackVec * 1f, new Color(0, 1, 0));

        if ((rayHit = Physics2D.Raycast(transform.position, RightVec, 1f, LayerMask.GetMask("Player"))) || (rayHit = Physics2D.Raycast(transform.position, LeftVec, 1f, LayerMask.GetMask("Player"))) ||
           (rayHit = Physics2D.Raycast(transform.position, ForwardVec, 1f, LayerMask.GetMask("Player"))) || (rayHit = Physics2D.Raycast(transform.position, BackVec, 1f, LayerMask.GetMask("Player"))))
        {
            //Panel_.SetActive(true);
            if (Input.GetButtonDown("Jump"))
            {
                Panel_.SetActive(true);
                Button_.SetActive(true);
            }

        }

    }
}
