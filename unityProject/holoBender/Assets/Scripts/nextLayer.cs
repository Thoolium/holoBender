// A script that will assist in debugging and creation of our program
// it is used to manually switch between layers showing different tasks the user will perform
// this should be replaced with automatic checks or timers created for each layer

using UnityEngine;

public class nextLayer : MonoBehaviour
{
    // define starting layer
    public int currentLayer = 8;

    // function that is performed on button click
    public void isClicked()
    {

        // Loop Back To Start if already on final layer
        if  (currentLayer == 14)
        {
            currentLayer = 8;
        }

        // go to the next layer in not on final layer
        else
        {
            currentLayer++;
        }

        // set mask to show the base layers (1,2,4,8,16,32) and the chosen layer
        // note this is done as a bitwise calculation as the cullingMask value is a binary value
        //e.g. 0010 1101 0011 1001 0001
        Camera.main.cullingMask = 1+2+4+8+16+32 | 1 << currentLayer;


        // play music on positive reinforcement layer, mostly as proof of concept
        // music should be activated from relevant triggers and not from this funciton
        if (currentLayer == 14)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}

