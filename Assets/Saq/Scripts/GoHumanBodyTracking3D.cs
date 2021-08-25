using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHumanBodyTracking3D : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("HumanBodyTracking3D");
    }
}

