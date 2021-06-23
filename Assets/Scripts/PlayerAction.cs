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
    Vector3 dirVec;
    GameObject scanObject;

    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
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
        if (hDown)
            isHorizonMove = true;
        else if (vDown)
            isHorizonMove = false;
        else if (hUp || vUp)
            isHorizonMove = h != 0;

        //Direction
        if (vDown && v == 1)
            dirVec = Vector3.up;
        else if (vDown && v == -1)
            dirVec = Vector3.down;
        else if (hDown && h == -1)
            dirVec = Vector3.left;
        else if (hDown && h == 1)
            dirVec = Vector3.right;

        ////Move
        //Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        //transform.Translate(moveVec * speed * Time.deltaTime);

        //Ray
        Debug.DrawRay(transform.position, dirVec * 0.7f, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(transform.position, dirVec, 0.7f, LayerMask.GetMask("Object"));

        if (rayHit.collider != null)
        {
            scanObject = rayHit.collider.gameObject;
        }
        else
            scanObject = null;

        //Scan Object
        if (Input.GetButtonDown("Jump") && scanObject != null)
            Debug.Log("scan : " + scanObject);
    }

    private void FixedUpdate()
    {
        //Move
        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rigid.velocity = moveVec * speed;
    }
}
