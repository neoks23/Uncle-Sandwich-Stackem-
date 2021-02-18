using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    bool highScore;
    Text txt;
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (highScore)
        {
            txt.text = "HIGHSCORE: " + Void.highScore.ToString();
        }
        else
        {
            txt.text = "SCORE: " + Void.score.ToString();
        }
    }
}
