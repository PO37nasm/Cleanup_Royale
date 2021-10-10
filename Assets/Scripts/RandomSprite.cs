using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    [SerializeField] public List<Sprite> sprites;
    // Start is called before the first frame update
    void Start()
    {
        int spriteSelect = Random.Range(0, sprites.Count);
        GetComponent<SpriteRenderer>().sprite = sprites[spriteSelect];
    }
}
