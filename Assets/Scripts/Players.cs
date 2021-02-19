using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < SinglePlayerCharacterSelectionPlay.totalPlayers; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
