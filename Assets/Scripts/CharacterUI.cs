using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterUI : MonoBehaviour
{
    Image character;
    [SerializeField]
    int i;
    // Start is called before the first frame update
    void Start()
    {
        character = transform.GetChild(1).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (i)
        {
            case 0:
                character.sprite = SinglePlayerCharacterSelectionPlay.player1;
                break;
            case 1:
                character.sprite = SinglePlayerCharacterSelectionPlay.player2;
                break;
            case 2:
                character.sprite = SinglePlayerCharacterSelectionPlay.player3;
                break;
            case 3:
                character.sprite = SinglePlayerCharacterSelectionPlay.player4;
                break;
        }        
    }
}
