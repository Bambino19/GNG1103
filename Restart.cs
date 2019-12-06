using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Restart : MonoBehaviour
{

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // loads current scene
        //SceneManager.LoadScene("CT Scan");
        //Destroy(SceneManager)
        //SceneManager.LoadScene(0);
       
    }

    public void Gaze()
    {
        SceneManager.LoadScene("Gaze Menu");
    }

    public void Controller()
    {
        SceneManager.LoadScene("Controller Menu");
    }
}