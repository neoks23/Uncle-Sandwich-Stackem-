using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Void : MonoBehaviour
{
    public static int highScore;
    public static int score;
    public static string player;
    public bool multiplayer;
    public string scene;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (!multiplayer)
        {
            int score = FindObjectOfType<ScoreText>().Score;
            if (score > highScore)
            {
                highScore = score;
            }
            Void.score = score;
            SceneManager.LoadScene(scene);
        }
        else
        {
            int score = FindObjectOfType<ScoreText>().Score;
            if (SinglePlayerCharacterSelectionPlay.totalPlayers < 3)
            {
                if(score % 2 == 0)
                {
                    player = "P2";
                }
                else
                {
                    player = "P1";
                }
            }
            if (score > highScore)
            {
                highScore = score;
            }
            Void.score = score;
            SceneManager.LoadScene(scene);
        }
    }
}
