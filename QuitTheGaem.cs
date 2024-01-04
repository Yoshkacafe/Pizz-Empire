using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitTheGaem : MonoBehaviour
{
    public void QuitTheGame()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }
}