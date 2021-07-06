using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskMove : MonoBehaviour
{
    Vector3 RightVec;
    Vector3 LeftVec;
    Vector3 ForwardVec;
    Vector3 BackVec;

    RaycastHit2D rayHit;
    public Animator animator;
    // Start is called before the first frame update
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
        Debug.DrawRay(transform.position, RightVec * 2f, new Color(0, 1, 0));
        Debug.DrawRay(transform.position, LeftVec * 2f, new Color(0, 1, 0));
        Debug.DrawRay(transform.position, ForwardVec * 2f, new Color(0, 1, 0));
        Debug.DrawRay(transform.position, BackVec * 2f, new Color(0, 1, 0));

        if ((rayHit = Physics2D.Raycast(transform.position, RightVec, 2f, LayerMask.GetMask("Player"))) || (rayHit  = Physics2D.Raycast(transform.position, LeftVec, 2f, LayerMask.GetMask("Player"))) || 
           (rayHit = Physics2D.Raycast(transform.position, ForwardVec, 2f, LayerMask.GetMask("Player"))) || (rayHit = Physics2D.Raycast(transform.position, BackVec, 2f, LayerMask.GetMask("Player"))))
            animator.SetBool("isRay", true);
        
    }

    
}
