using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMenu : MonoBehaviour
{
    public GameObject Canvas;

    void Start()
    {
        Debug.Log("Executed");
        Canvas = GameObject.Find("MainMenuManager");
        Canvas.transform.position = new Vector3(30, 7, -10);
        Canvas.transform.localEulerAngles = new Vector3(0, 90, 90);
        //Canvas.transform.Rotate(0, 0, 90);
        //MainMenu.GetComponent<RectTransform>().localPosition = Canvas;
    }
}
