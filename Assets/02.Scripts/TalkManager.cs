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

        talkData.Add(11, new string[] { "누군가의 일기장이다.", "읽어보자.", "?? : 부모님이 돌아가셨다. 친구들이 많이 위로해주는거 같지만", "?? : 나를 대하는 태도가 예전이랑 많이 달라졌다.", "?? : 내가 부모를 잃었기 때문일까?" });
        talkData.Add(12, new string[] { "여기에 또다른 일기장이 있다.", "읽어보자." , "?? : 친구들이 괴롭히기 시작했다.", "?? : 어제까지 친하던 친구들이 이렇게 돌변하다니...","?? : 나를 더이상 친구를 보는거 같지 않다.", " ?? : 힘들다..." });
        talkData.Add(13, new string[] { "또다른 일기장을 발견했다.", "내용을 확인해보자.", "?? : 괴롭힘이 심해졌다.", "?? : 어제는 친구에게 맞아 몸에 피멍이 생겼다.", "?? : 학교 가기 싫다..","?? : 이렇게 사는게 의미가 있을까..?", "?? : 오늘은 또 그녀석들이 옥상으로 부른다.","?? : 나를 왜 부른걸까..?"});   
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
