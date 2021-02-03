using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Sprite> sprites = new List<Sprite>();
    SpriteRenderer face;

    private void Start()
    {
        face = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }
    public void UpdateFace(int index)
    {
        face.sprite = sprites[index];
    }
}
