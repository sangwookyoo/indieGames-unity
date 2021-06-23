using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XGAResolution : MonoBehaviour
{
    void Awake()
    {
        Screen.SetResolution(1024, 768, false);
    }
}
