using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForegroundScroll : MonoBehaviour
{
    public float width; 
    public float startPos;
    void Start()
    {       
         width = GetComponent<SpriteRenderer>().bounds.size.x;
         startPos = this.transform.position.x; 
    }

    void Update()
    {
        Vector3 depl = new Vector3(-5 * Time.deltaTime, 0);
        transform.position += depl;
        
        if (transform.position.x < -width)
        {
            transform.position = new Vector3(width, transform.position.y);
        }
    }
}
