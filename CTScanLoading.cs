using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CTScanLoading : MonoBehaviour
{ 
public void CTScan() // This MUST be inserted otherwise the script doesn't work, also the name of the scene to be loaded has to be where it says NewLebel (delete NewLebel and replace it with your scene name
{
    Debug.Log("CT Scan Controller");
    SceneManager.LoadScene("CT Scan Controller");
}

void OnCollisionEnter(Collision other)
{

    //this finds the game object called "Ball" in the scene
    if (other.gameObject.CompareTag("Ball")) // If what collided with the cube is called "Ball" it will do what the code says which is load a new scene. If your player is called "Hulk" in the scene you would put "Hulk" instead of ball
        Debug.Log("CT Scan Controller");
    SceneManager.LoadScene("CT Scan Controller"); // this looks for the scene  and loads it. Whatever scene you want to load you put in the "", say your scene is called "Goat" you put that in the ""
}
}