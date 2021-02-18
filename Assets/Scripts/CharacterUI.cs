using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterUI : MonoBehaviour
{
    Image character;
    // Start is called before the first frame update
    void Start()
    {
        character = transform.GetChild(1).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        character.sprite = SinglePlayerCharacterSelectionPlay.character;
    }
}
