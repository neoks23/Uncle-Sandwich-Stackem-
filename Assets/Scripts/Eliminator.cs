using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eliminator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cross;
    Eliminated el;
    public void Eliminate(Vector3 v)
    {
        el = cross.GetComponent<Eliminated>();
        el.X = v.x;
        el.Y = v.y;
    }
    public void Instantiate()
    {
        Instantiate(el, transform, false);
    }
}
