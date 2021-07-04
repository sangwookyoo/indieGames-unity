using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public Text talkText;
    public bool isAction;
    public bool isLoadFile1;
    public bool isLoadFile2;
    public bool isLoadFile3;
    public int talkIndex;
    public GameObject MenuSet;
    public GameObject scanObject;
    public GameObject talkPanel;
    public GameObject Player;
    // Start is called before the first frame update
    


    private void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("isLoadFile"));
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

    #region 저장하기
    public void GameSave1()
    {
        PlayerPrefs.SetFloat("FirstPlayerX" ,Player.transform.position.x);
        PlayerPrefs.SetFloat("FirstPlayerY" ,Player.transform.position.y);
        PlayerPrefs.Save();
        MenuSet.SetActive(false);
    }
    public void GameSave2()
    {
        PlayerPrefs.SetFloat("SecondPlayerX", Player.transform.position.x);
        PlayerPrefs.SetFloat("SecondPlayerY", Player.transform.position.y);
        PlayerPrefs.Save();
        MenuSet.SetActive(false);
    }
    public void GameSave3()
    {
        PlayerPrefs.SetFloat("ThirdPlayerX", Player.transform.position.x);
        PlayerPrefs.SetFloat("ThirdPlayerY", Player.transform.position.y);
        PlayerPrefs.Save();
        MenuSet.SetActive(false);
    }
    #endregion
    #region 불러오기
    public void GameLoad()
    {
        if (PlayerPrefs.HasKey("FirstPlayerX") || PlayerPrefs.HasKey("SecondPlayerX") || PlayerPrefs.HasKey("ThirdPlayerX"))
        {
            if (PlayerPrefs.GetInt("isLoadFile") == 1)
            {
                float x = PlayerPrefs.GetFloat("FirstPlayerX");
                float y = PlayerPrefs.GetFloat("FirstPlayerY");

                Player.transform.position = new Vector2(x, y);
            }
            else if (PlayerPrefs.GetInt("isLoadFile") == 2)
            {
                float x = PlayerPrefs.GetFloat("SecondPlayerX");
                float y = PlayerPrefs.GetFloat("SecondPlayerY");

                Player.transform.position = new Vector2(x, y);
            }
            else if (PlayerPrefs.GetInt("isLoadFile") == 3)
            {
                float x = PlayerPrefs.GetFloat("ThirdPlayerX");
                float y = PlayerPrefs.GetFloat("ThirdPlayerY");

                Player.transform.position = new Vector2(x, y);
            }
            else if (PlayerPrefs.GetInt("isLoadFile") == 0)
            {
                Player.transform.position = new Vector2(1, 1);
            }
        }
    }
  
    #endregion
}
s