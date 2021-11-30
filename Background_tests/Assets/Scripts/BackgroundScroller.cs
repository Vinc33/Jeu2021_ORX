using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        transform.position += new Vector3(-1 * Time.deltaTime, 0);

        if (transform.position.x < -20.69)
        {
            transform.position = new Vector3(20.69f, transform.position.y);
        }

    }
}
