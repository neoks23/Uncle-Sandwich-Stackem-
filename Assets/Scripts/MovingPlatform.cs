using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovingPlatform : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Stack> list = new List<Stack>();
    public Transform bg;
    public StackContainer stackContainer;
    public Camera camera;
    Random rnd;
    bool state = true;
    float boundaries = 2.0f;
    public float moveSpeed = 0.05f;
    int layer = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state)
        {
            transform.position += new Vector3(moveSpeed, 0.0f, 0.0f);
        }
        else
        {
            transform.position -= new Vector3(moveSpeed, 0.0f, 0.0f);
        }
        if(transform.position.x > boundaries)
        {
            state = false;
        }
        else if(transform.position.x < -boundaries)
        {
            state = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<FaceUpdater>().UpdateFace(2);
            foreach(Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
        }
    }

    public void CreateNew()
    {
        transform.position += new Vector3(0, 0.25f, 0);
        camera.orthographicSize += 0.1f;
        bg.localScale += new Vector3(0.02f, 0.02f, 0);
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }

        layer++;
        foreach(Stack stack in list)
        {
            SpriteRenderer sprite = stack.GetComponent<SpriteRenderer>();
            sprite.sortingOrder = layer;
        }
        Instantiate(list[Random.Range(0, list.Count)],stackContainer.transform, true);
    }
}
