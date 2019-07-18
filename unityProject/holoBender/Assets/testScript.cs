using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testScript : MonoBehaviour
{

    public int timing = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ++timing ;

        if (timing > 250 )
        {
            SceneManager.LoadScene("testing2", LoadSceneMode.Single);
            Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
        }
    }
}
