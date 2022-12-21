using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    /*
    // [SerializeField] is used to expose the varaible into Unity's inerface
    // define a new variable of type integer ( whole numbers)
    [SerializeField] int wholeNumber = 0;

    // define a new variable of type float (fractional numbers)
    [SerializeField] float fraction = 1.5f;

    //define a new variable of type string (text)
    [SerializeField] string myText = "This is a new string";

    //define a new variable of type boolean (true or false)
    [SerializeField] bool myBool = true;
    */
    
    //define a new variable of type float ( this will control the speed of the player)
    [SerializeField] float speed = 1f;

    

    // Update is called once per frame
    void Update()
    {
        //define a new variable of type float that will get player input in the horizontal direction
        //this happens when players press A/left arrow (-1) or D/right arrow(+1)
        float horizontalMovement = Input.GetAxis("Horizontal");

        // define a new variable of type float that will get player input in the vertical direction
        // vertical or horizontal relate to the input axis direction ( up/down or left/right)
        //this registers when player press W/up arrow (+1) or S/down arrow(-1)
        float verticalMovement = Input.GetAxis("Vertical");

        //this line defines a new variable of the type Vector3 which has the horizontalMovement 
        // variable as its x component, and verticalMovement variable as its z component
        Vector3 movementDirection = new Vector3(horizontalMovement, 0, verticalMovement);

        // updates the current position of the game object which this script is attached to
        //adds a vector defined by what the playerhas pressed , multiplied by the speed , and also 
        //Time.deltaTime which is the value of how much time every frame will take
        // the point of multiplying with Time.deltaTime is to make speed consistant across all devices
        transform.position = transform.position + movementDirection
            * speed * Time.deltaTime;

        //this line prints the movement directn variable into console for debugging
        Debug.Log(movementDirection);

        //if statement test a certain condition
        //if (wholeNumber <= 1000)
        //{
        //    wholeNumber = wholeNumber + 1;
        //    Debug.Log(wholeNumber);
        //}
    }
}
