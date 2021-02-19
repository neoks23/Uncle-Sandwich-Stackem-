using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWin : MonoBehaviour
{
    // Start is called before the first frame update
    Text txt;
    void Start()
    {
        txt = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = Void.player + " WON";
    }
}
