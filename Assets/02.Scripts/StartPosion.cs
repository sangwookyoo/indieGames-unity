using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPosion : MonoBehaviour
{
    public string transferMapName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transferMapName = SceneManager.GetActiveScene().name;
        }
    }
}
