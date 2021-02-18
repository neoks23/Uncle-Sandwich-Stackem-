using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Character : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    Image SelectedCharacter;
    bool selected = false;

    [SerializeField]
    int Cindex;
    int[] x = {-200,-100,0,100 };
    int[] y = { 100, 0 };

    public bool Selected
    {
        get { return selected; }
    }

    void Start()
    {
        SelectedCharacter = transform.parent.GetChild(8).GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Transform t = transform.parent;
        foreach(Transform child in t)
        {
            if (child.GetComponent<Character>() != null)
            {
                Character c = child.GetComponent<Character>();
                c.selected = false;
            }
        }
        FindObjectOfType<SinglePlayerCharacterSelectionPlay>().IsSelected = false;
        SelectedCharacter.color = new Color32(255, 255, 255, 255);
        for (int i = 0; i < x.Length * y.Length; i++)
        {
            if(i == Cindex)
            {
                SelectedCharacter.rectTransform.localPosition = new Vector3(x[i % x.Length], i >= 4 ? y[1] : y[0] ,0);
            }
        }
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        selected = true;
        SelectedCharacter.color = new Color32(0, 255, 0, 255);
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        
    }
}
