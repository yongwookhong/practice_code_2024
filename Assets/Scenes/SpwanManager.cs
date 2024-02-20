using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject[] playerobj;

    // Start is called before the first frame update
    void Start()
    {
    //데이터 매니저에서 플레이어 ID를 받아옴
    int playerID = DataManager.instance.currentID;
        // 해당하는 플레이어 ID 오브젝트를 생성
        Instantiate(playerobj[playerID]);

    }

}
