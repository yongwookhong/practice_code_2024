using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject[] playerobj;

    // Start is called before the first frame update
    void Start()
    {
    //������ �Ŵ������� �÷��̾� ID�� �޾ƿ�
    int playerID = DataManager.instance.currentID;
        // �ش��ϴ� �÷��̾� ID ������Ʈ�� ����
        Instantiate(playerobj[playerID]);

    }

}
