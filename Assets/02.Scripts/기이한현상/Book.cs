using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    Vector3 RightVec;
    Vector3 LeftVec;
    Vector3 ForwardVec;
    Vector3 BackVec;

    public GameObject book;
    RaycastHit2D rayHit;
    public AudioSource audioSource;
    //public Animator animator;
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
        Debug.DrawRay(transform.position, RightVec * 3f, new Color(0, 1, 0));
        Debug.DrawRay(transform.position, LeftVec * 3f, new Color(0, 1, 0));
        Debug.DrawRay(transform.position, ForwardVec * 3f, new Color(0, 1, 0));
        Debug.DrawRay(transform.position, BackVec * 3f, new Color(0, 1, 0));

        if ((rayHit = Physics2D.Raycast(transform.position, RightVec, 3f, LayerMask.GetMask("Player"))) || (rayHit = Physics2D.Raycast(transform.position, LeftVec, 3f, LayerMask.GetMask("Player"))) ||
           (rayHit = Physics2D.Raycast(transform.position, ForwardVec, 3f, LayerMask.GetMask("Player"))) || (rayHit = Physics2D.Raycast(transform.position, BackVec, 3f, LayerMask.GetMask("Player"))))
        {
            book.SetActive(true);
            audioSource.Play();
        }

    }
}
