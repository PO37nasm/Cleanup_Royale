using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivePointer : MonoBehaviour
{
    [SerializeField]
    private GameObject exit;
    [SerializeField]
    private GameObject graphic;
    // Start is called before the first frame update
    void Start()
    {
        graphic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vectorToTarget = new Vector3(exit.transform.position.x - transform.position.x, exit.transform.position.y - transform.position.y, 0);
        transform.rotation = Quaternion.LookRotation(forward: Vector3.forward, -vectorToTarget);
    }

    public void Appear()
    {
        graphic.SetActive(true);
    }
    
}
