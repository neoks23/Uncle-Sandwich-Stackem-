using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    // Start is called before the first frame update
    Void _void;
    RectTransform rect;
    void Start()
    {
        _void = FindObjectOfType<Void>();
        rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        int score = FindObjectOfType<ScoreText>().Score;
        rect.localPosition = new Vector3(_void.Points_x[score % _void.Points_x.Count], _void.Points_y[score % _void.Points_y.Count], 0);
    }
}
