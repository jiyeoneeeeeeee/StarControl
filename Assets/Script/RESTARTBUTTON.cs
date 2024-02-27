using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RESTARTBUTTON : MonoBehaviour
{
    public void Func_RESTART()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
    }
}
