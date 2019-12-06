using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGaze : MonoBehaviour
{
    public void Gaze() // This MUST be inserted otherwise the script doesn't work, also the name of the scene to be loaded has to be where it says NewLebel (delete NewLebel and replace it with your scene name
    {
        Debug.Log("Gaze Menu");
        SceneManager.LoadScene("Gaze Menu");
    }
}