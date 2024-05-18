using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
     public int maxHealth;       //determines max amount of health the player can have
    public int currentHealth;   //tracks current health of the player

    //store visual representation of health
    public GameObject hp1;      
    public GameObject hp2;
    public GameObject hp3;


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 3;                  //set max health to two
        currentHealth = maxHealth;      //set current health to max health
    }

    //Function for when the player takes damages
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;                        //lower health
          
          if (currentHealth == 3)                        //if health equal two
        {
            hp3.SetActive(false);  
        }
       
        if (currentHealth == 2)                         //if health equal two
        {
            hp2.SetActive(false);                                       //lose a heart
        }
        if (currentHealth == 1)                         //if health equal one
        {
            hp1.SetActive(false);                     //lose a heart
        }

        if (currentHealth <= 0)                         //if health equal zero
        {
            SceneManager.LoadScene("Overworld");         //go to GameOver Scene
        }
    }
}