using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public Text talkText;
    public bool isAction;
    public int talkIndex;
    public GameObject MenuSet;
    public GameObject scanObject;
    public GameObject talkPanel;
    public GameObject Player;
    // Start is called before the first frame update


    private void Start()
    {
        GameLoad();
    }
    private void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if (MenuSet.activeSelf)
                MenuSet.SetActive(false);
            else
            MenuSet.SetActive(true);
        }
    }
    public void Action(GameObject scanObj)
    {
        isAction = true;
        scanObject = scanObj;
        ObjData objData = scanObject.GetComponent<ObjData>();
        Talk(objData.id, objData.isNpc);
        
        talkPanel.SetActive(isAction);
    }

    void Talk(int id, bool isNpc)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if(talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            return;
        }

        if(isNpc)
        {
            talkText.text = talkData;
        }
        else
        {
            talkText.text = talkData;
        }

        isAction = true;
        talkIndex++;
    }
    public void GameExit()
    {
        Application.Quit();
    }

    public void GameSave()
    {
        PlayerPrefs.SetFloat("PlayerX" ,Player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY" ,Player.transform.position.y);
        PlayerPrefs.Save();

        MenuSet.SetActive(false);
    }
    public void GameLoad()
    {
        float x = PlayerPrefs.GetFloat("PlayerX");
        float y = PlayerPrefs.GetFloat("PlayerY");

        Player.transform.position = new Vector3(x, y, 0);
    }
}
