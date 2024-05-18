using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousedrag : MonoBehaviour
{ 
   Transform startPos;
   float startPosX;
   float startPosY;
   bool isBeingHeld;
   
    // Start is called before the first frame update
    void Start()
    {
        startPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isBeingHeld)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            gameObject.transform.localPosition = new Vector2(mousePos.x, mousePos.y);  
            /*or gameObject.transform.localPosition = new Vector2(mousePos.x, transform.position.y);
             if you want to move object like paddle from pong game with mouse on a specific axis.*/
        }
    }

  void OnMouseDown()
{

if (Input.GetMouseButton(0))
{
    Vector2 mousePos;
    mousePos = Input.mousePosition;
    isBeingHeld = true;
    Debug.Log("Click");

}

}

void OnMouseUp()
{

isBeingHeld = false;
}

}
