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

    int DiaryCount = 0;
    int DiaryCount2 = 0;
    int objDataId;

    public GameObject MenuSet;
    public GameObject scanObject;
    public GameObject talkPanel;
    public GameObject Player;
    public GameObject DiaryContents;

    Vector3 LeftVec;
    RaycastHit2D rayHit;

    public AudioSource audioSource;
    public GameObject Wall;
    public AudioClip EffectSound;


    private void Awake()
    {
        Player = Resources.Load("Player") as GameObject;
    }
    private void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("isLoadFile"));
        GameLoad();
    }

   
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
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
        //Get Diary
       

        Talk(objData.id, objData.isNpc);
        talkPanel.SetActive(isAction);
    }

    void Talk(int id, bool isNpc)
    {
        ObjData objData = scanObject.GetComponent<ObjData>();
        string talkData = talkManager.GetTalk(id, talkIndex);
        
        if(talkData == null)
        {
            
            isAction = false;
            talkIndex = 0;
            DiaryContents.SetActive(false);
            if (objData.id == 11 || objData.id == 12)
            {
                
                PlayerPrefs.SetInt("objDataId", objData.id);
                DiaryCount++;
                PlayerPrefs.SetInt("DiaryCount", DiaryCount);

                if (DiaryCount == 2)
                {
                    audioSource.PlayOneShot(EffectSound, 0.7f);
                    Destroy(Wall);
                }
                
            }

            if (objData.id == 13)
            {
                PlayerPrefs.SetInt("objDataId", objData.id);
                DiaryCount2++;
                PlayerPrefs.SetInt("DiaryCount", DiaryCount2);

                if (DiaryCount2 == 1)
                {
                    audioSource.PlayOneShot(EffectSound, 0.7f);
                    PlayerPrefs.SetInt("num", DiaryCount2);
                }

            }

            Debug.Log(PlayerPrefs.GetInt("DiaryCount"));
            return;
        }

        if(isNpc)
        {
            talkText.text = talkData;
        }
        else
        {
            talkText.text = talkData;
            if (objData.id == 11 || objData.id == 12 || objData.id == 13)
            {
                DiaryContents.SetActive(true);
            }
            
        }

        isAction = true;
        talkIndex++;
    }
    public void GameExit()
    {
        Application.Quit();
    }

    #region save
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
    #region load
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
