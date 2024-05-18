using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterfaceOW : MonoBehaviour
{
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 characterScale = transform.localScale;
       
         if (Input.GetAxisRaw("Horizontal") < 0) 
         {
            characterScale.x = -8;
         }
       
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            characterScale.x = 8;
        }
        
        else if (Input.GetAxisRaw("Vertical") < 0) 
        {
            characterScale.z = -90;
        }

        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            characterScale.z = -90;
        }

    transform.localScale = characterScale;
    }
}
