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
        talkData.Add(11, new string[] { "누군가의 일기장이다.", "읽어보자.", "?? : 부모님이 돌아가셨다. 친구들이 많이 위로해주는거 같지만", "?? : 나를 대하는 태도가 예전이랑 많이 달라졌다.", "?? : 내가 부모를 잃었기 때문일까?" });
        talkData.Add(12, new string[] { "여기에 또다른 일기장이 있다.", "읽어보자.", "?? : 친구들이 괴롭히기 시작했다.", "?? : 어제까지 친하던 친구들이 이렇게 돌변하다니...", "?? : 나를 더이상 친구를 보는거 같지 않다.", " ?? : 힘들다..." });
        talkData.Add(13, new string[] { "또다른 일기장을 발견했다.", "내용을 확인해보자.", "?? : 괴롭힘이 심해졌다.", "?? : 어제는 친구에게 맞아 몸에 피멍이 생겼다.", "?? : 학교 가기 싫다..", "?? : 이렇게 사는게 의미가 있을까..?", "?? : 오늘은 또 그녀석들이 야자시간이 끝난 뒤 10시에 옥상으로 오라고 부른다.", "?? : 나를 왜 부른걸까..?" });
        talkData.Add(21, new string[] { "아직 문이 열리지 않은 모양이다."});
        talkData.Add(1001, new string[] { "안녕?", " 나는 애기동동이라고해" });
        talkData.Add(1002, new string[] { " 드디어 날 바라봐주는구나.", "...", "마지막 이야기야.","그날 옥상에서도 난 괴롭힘을 당했어", "그녀석들이 날 괴롭히던 와중에 우리 엄마 유품을 던져버린거야", "그래서 유품을 잡으려다 그만 옥상에서 떨어졌어", "그러고 1시간동안 살아있었지만 아무도 나를 도와주지 않았어", "그래서 이런일을 벌인거야 복수하고 싶어서", "그런데 의미없는 짓이란걸 알았어", "널 괴롭혀서 미안해...", "이제 널 이시간속에서 벗어나게 해줄게...","안녕.." });

    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }
}
