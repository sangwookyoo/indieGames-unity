using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.Audio;
using UnityEngine.UI;

public class OnOff : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider audioSlider;

    bool onoff_; //창 onoff 확인

    public void AudioControl() //0~100
    {
        float sound = audioSlider.value;

        if (sound == -40f) masterMixer.SetFloat("BGM", -80); //(아까 설정한 string, 볼륨 값)
        else masterMixer.SetFloat("BGM", sound);
    }

    public void AudioVolume() //on off
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0; //듣는이의 전체볼륨
    }

    public void WindowOpen(GameObject Window_) //설정onoff
    {
        onoff_ = !onoff_; //헐 대박사건 이거 넣으면 bool 껐다가 켰다가 작동
        Window_.SetActive(onoff_);
    }

    public void GameOut() //창닫기
    {
        Application.Quit();
    }
}
