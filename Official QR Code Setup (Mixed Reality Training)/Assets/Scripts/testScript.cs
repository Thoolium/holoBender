// A script used to test the scene changing functions
// kept in place as it contains addittional debugging functions that may come in handy 

using UnityEngine;
using UnityEngine.SceneManagement;

public class testScript : MonoBehaviour
{
    // create public variable showing time elapsed since script triggered
    public int timing = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // count frames/time elapsed
        ++timing ;

        // once timer reachers a set point change scenes and return the new scene name to the console
        if (timing > 250 )
        {
            SceneManager.LoadScene("testing2", LoadSceneMode.Single);
            Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
        }
    }
}
