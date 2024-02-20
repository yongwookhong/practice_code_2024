using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text nickname;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        nickname.text = GameManager.Instance.p_data.name + "님이 입장하셨습니다.";
        score.text = "점수:" + GameManager.Instance.p_data.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
