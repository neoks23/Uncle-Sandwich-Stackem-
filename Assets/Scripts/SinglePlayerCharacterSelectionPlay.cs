using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinglePlayerCharacterSelectionPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Characters;
    public static Sprite player1;
    public static Sprite player2;
    public static Sprite player3;
    public static Sprite player4;
    public static int totalPlayers = 0;
    bool isSelected = false;
    public Text txt;
    [SerializeField]
    bool multiplayer;
    int p = 0;

    public bool IsSelected
    {
        set { isSelected = value; }
    }
    public bool Multiplayer
    {
        get { return multiplayer; }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!multiplayer)
        {
            foreach (Transform child in Characters)
            {
                if (child.GetComponent<Character>() != null)
                {
                    Character c = child.GetComponent<Character>();
                    if (c.Selected)
                    {
                        isSelected = true;
                        ShowPlayBtn();
                        player1 = c.transform.GetChild(0).GetComponentInChildren<Image>().sprite;
                    }
                }
                else
                {
                    if (!isSelected)
                    {
                        HidePlayBtn();
                    }
                }
            }
        }
        else
        {
            p = 0;
            foreach (Transform child in Characters)
            {
                if (child.GetComponent<Character>() != null)
                {
                    Character c = child.GetComponent<Character>();
                    if (c.Selected)
                    {
                        isSelected = true;
                        

                        if (p > 0)
                        {
                            ShowPlayBtn();
                        }
                        switch (p)
                        {
                            case 0:
                                player1 = c.transform.GetChild(0).GetComponentInChildren<Image>().sprite;
                                break;
                            case 1:
                                player2 = c.transform.GetChild(0).GetComponentInChildren<Image>().sprite;
                                break;
                            case 2:
                                player3 = c.transform.GetChild(0).GetComponentInChildren<Image>().sprite;
                                break;
                            case 3:
                                player4 = c.transform.GetChild(0).GetComponentInChildren<Image>().sprite;
                                break;
                        }
                        p++;
                        totalPlayers = p;                        
                    }
                }
            }
        }        
    }
    public void HidePlayBtn()
    {
        this.GetComponent<Image>().enabled = false;
        this.GetComponent<Button>().enabled = false;
        this.transform.GetChild(0).GetComponent<Text>().enabled = false;
    }
    public void ShowPlayBtn()
    {
        this.GetComponent<Image>().enabled = true;
        this.GetComponent<Button>().enabled = true;
        this.transform.GetChild(0).GetComponent<Text>().enabled = true;
    }
}
