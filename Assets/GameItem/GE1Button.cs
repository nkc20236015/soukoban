using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GE1Button : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}