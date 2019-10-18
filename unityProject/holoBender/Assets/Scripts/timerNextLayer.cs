using UnityEngine;

public class timerNextLayer : MonoBehaviour
{

    public int currentLayer = 8;
    public int delayScale = 1;
    public int frameCount = 0;
    
    public AudioClip pickUpWires;
    public AudioClip placeWires;
    public AudioClip checkWires;
    public AudioClip holdButtons;
    public AudioClip releaseButtons;
    public AudioClip removeWires;
    public AudioClip positiveReinforcement;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(pickUpWires);
    }

    // Update is called once per frame
    void Update()
    {
        frameCount++;
        
        switch (currentLayer)
        {
            case 8:  // Pick Up Wires
                if (frameCount > (delayScale * 4))
                {
                    currentLayer++;
                    frameCount = 0;
                    audioSource.PlayOneShot(placeWires);
                }
                break;
            case 9:  // Place Wires
                if (frameCount > (delayScale * 4))
                {
                    currentLayer++;
                    frameCount = 0;
                    audioSource.PlayOneShot(checkWires);
                }
                break;
            case 10:  // Check Wires
                if (frameCount > (delayScale * 4))
                {
                    currentLayer++;
                    frameCount = 0;
                    audioSource.PlayOneShot(holdButtons);
                }
                break;
            case 11:  // Hold Buttons
                if (frameCount > (delayScale * 7))
                {
                    currentLayer++;
                    frameCount = 0;
                    audioSource.PlayOneShot(releaseButtons);
                }
                break;
            case 12:  // Release Buttons
                if (frameCount > (delayScale * 2))
                {
                    currentLayer++;
                    frameCount = 0;
                    audioSource.PlayOneShot(removeWires);
                }
                break;
            case 13:  // Move Wires
                if (frameCount > (delayScale * 3))
                {
                    currentLayer++;
                    frameCount = 0;
                    audioSource.PlayOneShot(positiveReinforcement);
                }
                break;
            case 14:  // Positive Reinforcement
                if (frameCount > (delayScale * 4))
                {
                    currentLayer = 8;
                    frameCount = 0;
                    audioSource.PlayOneShot(pickUpWires);
                }
                break;
        }

        Camera.current.cullingMask = 1 + 4 + 8 + 16 + 32 | 1 << currentLayer;
        
    }
}
