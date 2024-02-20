using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //레거시 텍스트 쓰기위해서 필요
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Text playerName;

 public void LoadMainScene()
    {
        //플레이어 데이터의 이름 저장
        //유니티에서 텍스트칸에 입력되는 자료를 가져오기
        //게임매니저의 인스턴스에서 플레이어 데이터의 이름에 접근 변수 p_data
        GameManager.Instance.p_data.name = playerName.text;

        // Main 씬 로드
        SceneManager.LoadScene("Main");

        // 로그
        Debug.Log(playerName.text);
        

    }
}
