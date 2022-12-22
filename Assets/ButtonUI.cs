using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string PlayTime = "Play";

  public void PlayButton()
    {
        SceneManager.LoadScene(PlayTime);
    }
}
