using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // 입출력 해주는거

public class GameManager : MonoBehaviour
{

    public class PlayerData
    {
        public string name;
        public int score;
    }

    public static GameManager Instance;
    public PlayerData p_data = new PlayerData(); // 플레이어 데이터 변수 선언
    string path;




    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destory(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Destory(GameObject gameObject)
    {
        throw new NotImplementedException();
    }

    //버튼을 누르면 저장하기

    public void SaveData()
    {
        string data =JsonUtility.ToJson(p_data, true); //Jsonutility에서 tojson을 불러와서 p_data를 저장한다
// true는 정렬 보기 좋게 하기 
        path = Path.Combine(Application.dataPath, p_data.name + "Json");
        File.WriteAllText(path, data);

    }

    public void LoadData()
    {
        string data = File.ReadAllText(path);
        p_data = JsonUtility.FromJson<PlayerData>(data);
    }

}
