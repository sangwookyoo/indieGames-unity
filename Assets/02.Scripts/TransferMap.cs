using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferMap : MonoBehaviour
{
    public string transferMapName;
    public string _preMapName;
    private PlayerAction thePlayer;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerAction>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(transferMapName);
            thePlayer.currentMapname = transferMapName;
            _preMapName = SceneManager.GetActiveScene().name;
            thePlayer.preMapname = _preMapName;
        }
    }
}