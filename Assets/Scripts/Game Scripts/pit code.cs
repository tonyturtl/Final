using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pitcode : MonoBehaviour
{

    Health damage;              //stores another scrip(nees to be the same name of the script)
    public GameObject player;   //stores  the player
    // Start is called before the first frame update
    void Start()
    {
        damage = player.GetComponent<Health>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D coll)
    {   
        if (coll.tag == "Player")   //if collision is with player
        {
            damage.TakeDamage(3);   //run the TakeDamage function from the Health script for 1 damage
        }
}
 
    // Called when a Collision is detected
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))  //if the object colling with is the player
        {
            SceneManager.LoadScene("Overworld");       //move to the Level2
        }
    }
}

