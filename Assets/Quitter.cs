using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitter : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        print("Quitted Succesfully!");
    }
}
