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
    [SerializeField]
    List<string> players;
    int total;
    // Start is called before the first frame update

    private void Start()
    {
        for (int i = 0; i < SinglePlayerCharacterSelectionPlay.totalPlayers; i++)
        {
            players.Add("P" + (i + 1).ToString());
        }
    }
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
                if (score % 2 == 0)
                {
                    player = "P2";
                }
                else
                {
                    player = "P1";
                }
                if (score > highScore)
                {
                    highScore = score;
                }
                Void.score = score;
                SceneManager.LoadScene(scene);
            }
            else
            {
                if (players.Count == 1)
                {
                    player = players[0];
                    if (score > highScore)
                    {
                        highScore = score;
                    }
                    Void.score = score;
                    SceneManager.LoadScene(scene);
                }
                if(score % players.Count == 0)
                {
                    players.RemoveAt(0);
                }
                else if(score % players.Count == 1)
                {
                    players.RemoveAt(1);
                }
                else if (score % players.Count == 2)
                {
                    players.RemoveAt(2);
                }
                else
                {
                    players.RemoveAt(3);
                }

                FindObjectOfType<StackContainer>().RemoveAll();                
            }
        }
    }
}
