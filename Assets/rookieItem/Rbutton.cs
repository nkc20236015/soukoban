using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}