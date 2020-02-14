using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cSharpNotes : MonoBehaviour
{
    //Faith Hoysted
    //Two foward slashes allows for comments these are not read by the engine
    //The top part of the script is generally where we store the variables.  Things like numbers, references to objects or references to other scrpits.
    //Variables have three parts, the 1st part is public or private, the second part is the type of variable and the third part is whatever we decide to name the variable

    //NUMBER VARIABLES
   //There are 2 common types of number variables floats and ints
   public float number; //float stands for floating point number which means the number has a decimal point
    public int wholenumber; // 1, 2, 3 are ints
    private float myhiddennumber; //a private variable is not visible instide the inspector

    //BOOLS (true/ false statements)
    public bool yesorno; // a bool is a yes or no statement, a binary, thing of it like a light switch, either on or off, no in between.

    //other common variables
    public GameObject mygameObject; // we can reference any object in our scene, all iteams in the heirarchy are considered gameobjects.
    public cSharpNotes csn; //we can also reference any script that have written as long as its public
    public Rigidbody2D myRB2D; // we use rigidbodies on players and enemies and anything we want to be affected by unity's physics
    public BoxCollider2D myboxcollider; //we can also reference colliders of all types
    public CircleCollider2D mycirclecollider;
    //We usually put these recerences at the top of the script we need to call them here first if we want to manipulate them later in the script

    // Start is called before the first frame update
    void Start()
    {
        //anything you want to happen when the game starts goes in here
        //sometimes we don't want to have to manually drag and drop items in the inspector
        //sometimes we want to spawn new items during gameplay. In this case we can use a few simple commands to have the script autuomatically find objects

        myRB2D = GetComponent<Rigidbody2D>(); // this will get the rigidbody but only if its on the same object as our script
        myRB2D = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        //this will find any object in our scene that has the tag player and get its rigidbody
        myRB2D = GameObject.FindObjectOfType<Rigidbody2D>();
        //this only works when there is no more than one rigidbody

        //when the game starts we also might want to look at a few different properties of our gameobjects, transform, position, rotation and scale
        transform.position = new Vector2(0, 0);
        //transform position is our location on x and y. transforms are ready by unity as something called a Vector (Vector 2 or Vector 3) Think
        //of a vector like a bar graph, the x is the horizontal and the y is the vertical
        //the vector 2 above is at origin position. another example would be
        transform.position = new Vector2(24, 128); //this would move us 24 units right and 126 units up
        //we can also manipulate scale this way
        transform.localScale = new Vector2(0, 0); //2D
        transform.localScale = new Vector3(0, 0, 0); //3D both these scales would be invisible
        //roation is a little more complicated we use quaternion and EULER (oiler)
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // inside the update function we call things that we want to update in real time as we play the game

        //IF STATEMENTS
        if (yesorno == true)
        {
            //we say yes
            //the player lives
        }

        if(yesorno == false)
        {
            //we say no
            //player dies
        }

        //this is also an example of how bools can work. if the bool is true one thing happens
        //if the bool is false something else happens
        //for the if statement to work we need a double = sign a single = means that the bool is true or is false whereas a double = checks to see if
        //its true or false

        if(number >= 10)
        {
            //we do something
        }

        // we can also use if statements to control the player
        if(Input.GetAxis("Horizontal") > 0)
        {
            //we nive the player
            myRB2D.velocity = new Vector2(25, 0);
        }

        if (Input.GetAxis("Horizontal") == 0)
        {
            //we want to stop the player
            myRB2D.velocity = new Vector2(0, 0); //this is a zero velocity
            //to see all the different rigidbody options we have just start typing myRB2D.
            myRB2D.gravityScale = 0.5f; //gives me half gravity
            myRB2D.simulated = false; // this means the rigid body is no longer affected by physics engine
            myRB2D.isKinematic = true; // kinematic rigidbody only moves if the code tells it to
            myRB2D.isKinematic = false; // non kinematic is the same as dynamic which means it is affected by the physics engine.
        }
        // IF ELSE STATEMENTS
        //if statements get read one after the other which can sometimes cause weird behavior
        //we can avoid this by using IF ELSE statements
        if (yesorno == true)
        {
            //we say yes
            //the player lives
            //if this turns out to be true we won't read the below else statement
        }

        else if (yesorno == false)
        {
            //we say no
            //player dies
            //if the above if statement is not true we will read this else statement
        }
        //because this code is in the update loop changes can happen quickly and we can cycle through multiple if statements faster than we want
        //this is why we use else
    }

    public void FixedUpdate()
    {
       //regular update is based on frame rate which means that a newer computer will run the code faster and an older computer will run the code slower
       //this is not ideal
       //for the most part graphical elements can live inside the update loop without issue
       //the fixed update loop is used for physics calculations as its called on a set interval which means that all computers run the code at the same speed
    }
}
