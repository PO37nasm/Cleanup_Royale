using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class RandomSprite : MonoBehaviour
{
    [SerializeField] public List<Sprite> sprites;
    // Start is called before the first frame update
    void Start()
    {
        int spriteSelect = Random.Range(0, sprites.Count);
        GetComponent<SpriteRenderer>().sprite = sprites[spriteSelect];
        if (GetComponent<Light2D>() != null && GetComponent<Light2D>().lightType == Light2D.LightType.Sprite)
        {
            GetComponent<Light2D>().lightCookieSprite = sprites[spriteSelect];
        }
    }
}
