using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapDepthSorter : MonoBehaviour
{
    void Start()
    {
        GetComponent<TilemapRenderer>().sortingOrder = -Mathf.RoundToInt(10 * GetComponent<Transform>().position.y);
    }
}

