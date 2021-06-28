using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaintainPlayer : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
