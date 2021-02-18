using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinglePlayerCharacterSelectionPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Characters;
    public static Sprite character;
    bool isSelected = false;

    public bool IsSelected
    {
        set { isSelected = value; }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Transform child in Characters)
        {
            if(child.GetComponent<Character>() != null)
            {
                Character c = child.GetComponent<Character>();
                if (c.Selected)
                {
                    isSelected = true;
                    this.GetComponent<Image>().enabled = true;
                    this.GetComponent<Button>().enabled = true;
                    this.transform.GetChild(0).GetComponent<Text>().enabled = true;
                    character = c.transform.GetChild(0).GetComponentInChildren<Image>().sprite;
                }
            }
            else
            {
                if (!isSelected)
                {
                    this.GetComponent<Image>().enabled = false;
                    this.GetComponent<Button>().enabled = false;
                    this.transform.GetChild(0).GetComponent<Text>().enabled = false;
                }                
            }
        }
    }
}
