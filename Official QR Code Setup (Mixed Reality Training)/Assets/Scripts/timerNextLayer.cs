using UnityEngine;

public class timerNextLayer : MonoBehaviour
{

    public int currentLayer = 8;
    public int timerCount = 0;
    public int timeDelay = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerCount++;

        if (timerCount > timeDelay)
        {
            // Loop Back To Start if already on final layer
            if (currentLayer == 14)
            {
                currentLayer = 8;
                timerCount = 0;
            }

            // go to the next layer in not on final layer
            else
            {
                currentLayer++;
                timerCount = 0;
            }

            // set mask to show the base layers (1,4,8,16,32) and the chosen layer
            // note this is done as a bitwise calculation as the cullingMask value is a binary value
            //e.g. 0010 1101 0011 1001 0001
            Camera.main.cullingMask = 1 + 4 + 8 + 16 + 32 | 1 << currentLayer;


            // play music on positive reinforcement layer, mostly as proof of concept
            // music should be activated from relevant triggers and not from this funciton
            if (currentLayer == 14)
            {
                GetComponent<AudioSource>().Play();
            }
        }
        else { }


    }
}
