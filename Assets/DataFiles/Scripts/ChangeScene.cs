using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // This script use to change screens
    public void DemoApp()
    {
        SceneManager.LoadScene("DemoApp");
    }
}
