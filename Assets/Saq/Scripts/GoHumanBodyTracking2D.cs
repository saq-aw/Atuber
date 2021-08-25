using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHumanBodyTracking2D : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("HumanBodyTracking2D");
    }
}

