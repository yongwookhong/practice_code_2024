using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // ����� ���ִ°�

public class GameManager : MonoBehaviour
{

    public class PlayerData
    {
        public string name;
        public int score;
    }

    public static GameManager Instance;
    public PlayerData p_data = new PlayerData(); // �÷��̾� ������ ���� ����
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

    //��ư�� ������ �����ϱ�

    public void SaveData()
    {
        string data =JsonUtility.ToJson(p_data, true); //Jsonutility���� tojson�� �ҷ��ͼ� p_data�� �����Ѵ�
// true�� ���� ���� ���� �ϱ� 
        path = Path.Combine(Application.dataPath, p_data.name + "Json");
        File.WriteAllText(path, data);

    }

    public void LoadData()
    {
        string data = File.ReadAllText(path);
        p_data = JsonUtility.FromJson<PlayerData>(data);
    }

}
