using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData; //배열로 스트링한 이유는 한 대화에 여러 대화가 있을 수 있기 때문

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }
        // Update is called once per frame
    void GenerateData()
    {

        talkData.Add(1, new string[] { "키보드 ← ↓ → ↑를 사용하여 친구에게 말을 걸어보세요." });
        talkData.Add(11, new string[] { "누군가의 일기장이다.", "읽어보자.", "일기장내용1", "일기장내용2", "일기장내용3" });
        talkData.Add(12, new string[] { "여기에 또다른 일기장이 있다." });
        talkData.Add(13, new string[] { "또다른 일기장을 발견했다.", "읽어보자." });
        talkData.Add(101, new string[] { "일기장내용1", "일기장내용2", "일기장내용3" });
        talkData.Add(1001, new string[] { "안녕?", " 나는 애기동동이라고해" });
        talkData.Add(1002, new string[] { " 드디어 날 바라봐주는구나.", "...", "마지막 일기장이야." });

    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }
}
