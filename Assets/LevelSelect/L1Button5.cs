using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L1Button5 : MonoBehaviour
{
   public void OnClickStartButton()
    {
         SceneManager.LoadScene("GameScene5");
    }
}