using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public void ResetPlayers()
    {
        Transform characters = FindObjectOfType<SinglePlayerCharacterSelectionPlay>().Characters;
        foreach(Transform character in characters)
        {
            if(character.childCount == 2)
            {
                Destroy(character.GetChild(1).gameObject);
            }
            if(character.GetComponent<Character>() != null)
            {
                Character c = character.GetComponent<Character>();
                c.Selected = false;
            }
        }
        SinglePlayerCharacterSelectionPlay.totalPlayers = 0;
        FindObjectOfType<SinglePlayerCharacterSelectionPlay>().txt.text = "Players:";
        FindObjectOfType<SinglePlayerCharacterSelectionPlay>().HidePlayBtn();
    }
}
