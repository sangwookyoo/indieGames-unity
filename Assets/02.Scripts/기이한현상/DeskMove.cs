using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskMove : MonoBehaviour
{
    Vector3 dirVec;

    RaycastHit2D rayHit;
    // Start is called before the first frame update
    void Start()
    {
        dirVec = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, dirVec * 1f, new Color(0, 1, 0));
        if (rayHit = Physics2D.Raycast(transform.position, dirVec, 0.7f, LayerMask.GetMask("Player")))
            Debug.Log("1");
            
    }
}
