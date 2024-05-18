using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb2d;
    private Transform currentPoint;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position = transform.position;
        if (currentPoint == pointB.transform)
        {
            rb2d.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb2d.velocity = new Vector2(-speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.2f && currentPoint == pointB.transform)
        {
            currentPoint = pointA.transform;  
        }
         if (Vector2.Distance(transform.position, currentPoint.position) < 0.2f && currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;  
        }
    }
}
