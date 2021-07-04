using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    public string sceneName;
    public GameObject onContinue;
    public GameObject offContinue;

    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        if (PlayerPrefs.HasKey("FirstPlayerX") || PlayerPrefs.HasKey("SecondPlayerX") || PlayerPrefs.HasKey("ThirdPlayerX"))
        {
            onContinue.SetActive(true);
            offContinue.SetActive(false);
        }
        else
        {
            onContinue.SetActive(false);
            offContinue.SetActive(true);
        }
    }
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