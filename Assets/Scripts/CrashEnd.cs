using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashEnd : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
    }
    public void OnClickExit()
    {
        SceneManager.LoadScene(0);
    }
}
