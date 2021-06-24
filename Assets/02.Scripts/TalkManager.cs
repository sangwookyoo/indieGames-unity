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
        TextAsset sr = Resources.Load("TalkFileTxtTest") as TextAsset;
        StringReader reader = new StringReader(sr.text);

        bool endOfFile = false;
        while (!endOfFile)
        {
            string data_String = reader.ReadLine();
            if (data_String == null)
            {
                endOfFile = true;
                break;
            }
            var data_values = data_String.Split(',');

            
            talkData.Add(int.Parse(data_values[0]), new string[] { data_values[1], data_values[2]});
            
        }
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }
}
