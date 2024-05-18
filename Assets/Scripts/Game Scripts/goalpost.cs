using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goalpost : MonoBehaviour
{
   
    // Called when a Collision is detected
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))  //if the object colling with is the player
        {
            SceneManager.LoadScene("Overworld");       //move to the Level2
        }
    }
}
        
  