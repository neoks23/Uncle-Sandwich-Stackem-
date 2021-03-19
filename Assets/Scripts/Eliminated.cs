using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eliminated : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float x, y;
    RectTransform r;

    public float X
    {
        set { x = value; }
    }
    public float Y
    {
        set { y = value; }
    }
    void Start()
    {
        r = this.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        r.localPosition = new Vector3(x, y, 0);
    }
}
