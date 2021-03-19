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
    [SerializeField]
    List<int> points_x;
    [SerializeField]
    List<int> points_y;
    int total;
    // Start is called before the first frame update
    public List<int> Points_x
    {
        get { return points_x; }
    }
    public List<int> Points_y
    {
        get { return points_y; }
    }

    private void Start()
    {
        for (int i = 0; i < SinglePlayerCharacterSelectionPlay.totalPlayers; i++)
        {
            players.Add("P" + (i + 1).ToString());
        }
        AddPoints();
    }

    void AddPoints()
    {
        points_x.Add(-770);
        points_y.Add(410);
        points_x.Add(850);
        points_y.Add(410);
        points_x.Add(-770);
        points_y.Add(-410);
        points_x.Add(850);
        points_y.Add(-410);
        if(players.Count > 3)
        {
            return;
        }
        points_x.RemoveAt(points_x.Count - 1);
        points_y.RemoveAt(points_y.Count - 1);
        if(players.Count > 2)
        {
            return;
        }
        points_x.RemoveAt(points_x.Count - 1);
        points_y.RemoveAt(points_y.Count - 1);
        return;
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
                Void.score = score;
                SceneManager.LoadScene(scene);
            }
            else
            {
                if (players.Count == 1)
                {
                    player = players[0];
                    Void.score = score;
                    SceneManager.LoadScene(scene);
                }
                if(score % players.Count == 0)
                {
                    players.RemoveAt(0);
                    Debug.Log("0");
                    FindObjectOfType<Eliminator>().Eliminate(new Vector3(points_x[0], points_y[0], 0));
                    FindObjectOfType<Eliminator>().Instantiate();
                    points_x.RemoveAt(0);
                    points_y.RemoveAt(0);
                }
                else if(score % players.Count == 1)
                {
                    players.RemoveAt(1);
                    Debug.Log("1");
                    FindObjectOfType<Eliminator>().Eliminate(new Vector3(points_x[1], points_y[1], 0));
                    FindObjectOfType<Eliminator>().Instantiate();
                    points_x.RemoveAt(1);
                    points_y.RemoveAt(1);
                }
                else if (score % players.Count == 2)
                {
                    players.RemoveAt(2);
                    Debug.Log("2");
                    FindObjectOfType<Eliminator>().Eliminate(new Vector3(points_x[2], points_y[2],0));
                    FindObjectOfType<Eliminator>().Instantiate();
                    points_x.RemoveAt(2);
                    points_y.RemoveAt(2);
                }
                else
                {
                    players.RemoveAt(3);
                    Debug.Log("3");
                    FindObjectOfType<Eliminator>().Eliminate(new Vector3(points_x[3], points_y[3], 0));
                    FindObjectOfType<Eliminator>().Instantiate();
                    points_x.RemoveAt(3);
                    points_y.RemoveAt(3);
                }

                FindObjectOfType<StackContainer>().RemoveAll();                
            }
        }
    }
}
