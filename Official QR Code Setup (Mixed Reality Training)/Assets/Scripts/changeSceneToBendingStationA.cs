// A script used to move between the welcome screen scene and individual machines
// at this stage there is only one machine to switch too so the function is simple

using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneToBendingStationA : MonoBehaviour
{
    //function that runs once the button is clicked
    public void isClicked()
    {
        SceneManager.LoadScene("bendingStationA");
    }

}