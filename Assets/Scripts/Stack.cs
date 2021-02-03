using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    // Start is called before the first frame update
    bool state = false;
    bool state2 = false;
    float timer = 0.0f;
    void Start()
    {
        transform.position = FindObjectOfType<MovingPlatform>().transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (state && !state2)
        {
            timer += Time.deltaTime;
            if(timer > 3.0f)
            {
                FindObjectOfType<FaceUpdater>().UpdateFace(1);
                FindObjectOfType<MovingPlatform>().CreateNew();
                FindObjectOfType<ScoreText>().Score++;
                state2 = true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Stack"))
        {
            FindObjectOfType<FaceUpdater>().UpdateFace(0);
            state = true;
        }
    }
}
