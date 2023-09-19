using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L1Button : MonoBehaviour
{
   public void OnClickStartButton()
    {
         SceneManager.LoadScene("GameScene1");
    }
}
