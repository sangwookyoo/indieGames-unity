using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    Vector3 LeftVec;
    public GameObject Window;
    RaycastHit2D rayHit;
    public GameObject GameManager;
    bool gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetComponent<GameManager>().isAction;
        LeftVec = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, LeftVec * 0.7f, new Color(0, 1, 0));
        if (rayHit = Physics2D.Raycast(transform.position, LeftVec, 0.5f, LayerMask.GetMask("Player")))
        {
            Window.SetActive(true);
            gm = false;
        }
    }
}
