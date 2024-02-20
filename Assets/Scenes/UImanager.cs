using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public player_manager pManager;
    int playerMaxNum;
    int playerCurrentNum;


    // Start is called before the first frame update
    void Start()
    {
        playerMaxNum = pManager.Players.Length;
    }

    public void SelectPlayer(bool isLeft)
    {
        if(isLeft)
        {
            if (playerCurrentNum > 0)
            {
                playerCurrentNum--;
                //�ش� �迭�� �÷��̾ ����
                pManager.SpawnPlayer(playerCurrentNum);
            }
        }

        else
        {
            if(playerCurrentNum < playerMaxNum -1)
            {
                playerCurrentNum++;
                pManager.SpawnPlayer(playerCurrentNum);
            }
        }

        DataManager.instance.currentID= playerCurrentNum;
    }

}
