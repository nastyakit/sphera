using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Vector3 EndPoint = new Vector3(3, 0, -11);
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

/*

public class Platform : MonoBehaviour {
    Vector3 Star = new Vector3(3, 0, 17);
    Vector3 End = new Vector3(3, 9, 5);
    bool t = true;
    
	void Start () {
		transform.position = End;
	}

	void Update () {
        if (true)
        {
            transform.position = Vector3.MoveTowards(Star, End, Time.deltaTime / 2);
        }
        /*
		if (t)
        {
            transform.position = Vector3.MoveTowards(transform.position, StartPoint, Time.deltaTime / 2);
            if (Vector3.Distance(Star, transform.position) <= 1)
            {
                t = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, StartPoint, Time.deltaTime / 2);
            if (Vector3.Distance(Star, transform.position) <= 1)
            {
                t = true;
            }
        }
        

	}
}*/
