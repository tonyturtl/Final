using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermove : MonoBehaviour
{
    //variables for the game
    float speed;        //determines move speed
    float move;         //determines direction of movement

    float jump;         //determines how high the jump is
    bool isJumping;     //tracks if object is jumping or not

    Rigidbody2D rb;     //place to store the rigidbody of the object

    public static charactermove instance;  //static variable that will hold Singleton

    // Called when script instance is being loaded
   void Awake()
   {
        // Make a Singleton to prevent more than one instance of an object
        if (instance == null)                   //if instance hasn't been set
        {
            DontDestroyOnLoad(gameObject);      //don't destroy object when loading new scene
            instance = this;                    //set instance to this object 
        }   
        else                                    //if instance is set to an object
        {
            Destroy(gameObject);                //destroy this object
        }
   } 

    // Start is called before the first frame update
    void Start()
    {
        speed = 8f;                        
        jump = 550f;                        

        rb = GetComponent<Rigidbody2D>();   //store the rb of the object
    }

    // Update is called once per frame
    void Update()
    {
        //move the player
        move = Input.GetAxis("Horizontal");                     //set move to read any of the Unity Horizontal keybinds

        rb.velocity = new Vector2(speed * move, rb.velocity.y); //move on the x axis(left or right)

        //single jump limit
        if (Input.GetButtonDown("Jump") && !isJumping)          //when the Unity Jump keybind is presses and if the object is not already jumping
        {
            rb.AddForce (new Vector2(rb.velocity.x, jump));     //jump
            isJumping = true;                                   //set jumping to true
        }
    }

    // Called when a Collision is detected
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))  //if the other object is tag as ground
        {
            isJumping =  false;                     //set jumping to false
        }
    }
}