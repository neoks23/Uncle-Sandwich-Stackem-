using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Void : MonoBehaviour
{
    public static int highScore;
    public static int score;
    public string scene;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        int score = FindObjectOfType<ScoreText>().Score;
        if(score > highScore)
        {
            highScore = score;
        }
        Void.score = score;
        SceneManager.LoadScene(scene);
    }
}
