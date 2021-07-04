using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    public string sceneName;
    public bool isLoadFile1 = false;
    public bool isLoadFile2 = false;
    public bool isLoadFile3 = false;
    public GameObject Player;

    public void OnButtonClick()
    {
        PlayerPrefs.SetInt("isLoadFile", 0);
        SceneManager.LoadSceneAsync(sceneName);
        Debug.Log(sceneName + "로 이동합니다.");
    }
    public void LoadFile1Click()
    {
        PlayerPrefs.SetInt("isLoadFile", 1);
        SceneManager.LoadSceneAsync(sceneName);
        Debug.Log(sceneName + "로 이동합니다.");
    }
    public void LoadFile2Click()
    {
        PlayerPrefs.SetInt("isLoadFile", 2);
        SceneManager.LoadSceneAsync(sceneName);
        Debug.Log(sceneName + "로 이동합니다.");
    }
    public void LoadFile3Click()
    {
        PlayerPrefs.SetInt("isLoadFile", 3);
        SceneManager.LoadSceneAsync(sceneName);
        Debug.Log(sceneName + "로 이동합니다.");
    }

}