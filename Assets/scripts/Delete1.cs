using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete1 : MonoBehaviour
{
    Vector3 EndPoint = new Vector3(3, 0, -21);
    bool m = true;
    Vector3 StartPoint;

    void Start()
    {
        StartPoint = transform.position;
    }

    void Update()
    {
        if (m == true && transform.position == EndPoint)
        {
            m = false;
        }
        else if (m == false && transform.position == StartPoint)
        {
            m = true;
        }
        if (m)
        {
            transform.position = Vector3.MoveTowards(transform.position, EndPoint, Time.deltaTime * 2);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, StartPoint, Time.deltaTime * 2);
        }
    }
}