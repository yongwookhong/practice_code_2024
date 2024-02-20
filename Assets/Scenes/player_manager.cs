using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{

    public GameObject[] Players;
    private GameObject currentPlayer;



    // Start is called before the first frame update
    void Start()
    {
        currentPlayer = Instantiate(Players[0]);
    }

    // Update is called once per frame
    public void SpawnPlayer(int playerID)
    {
        Destroy(currentPlayer);
        currentPlayer = Instantiate(Players[playerID]);
    }
}
