using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOut : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) 
        {
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
}