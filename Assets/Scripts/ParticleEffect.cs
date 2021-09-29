using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    public float despawnTime = 1f;
    private float timeOfSpawn;
    private void Awake()
    {
 
        timeOfSpawn = Time.fixedTime;
    }

    private void FixedUpdate()
    {
        if (Time.fixedTime - timeOfSpawn >= despawnTime)
        {
            Destroy(gameObject);
        }
    }
}
