using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackContainer : MonoBehaviour
{
    public Transform bun;
    public void RemoveAll()
    {
        foreach(Transform c in transform)
        {
            Destroy(c.gameObject);         
        }

        Instantiate(bun, transform, true);
        FindObjectOfType<MovingPlatform>().CreateNew();
    }
}
