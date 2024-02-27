using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HOME : MonoBehaviour
{
    public void Func_gotoMain()
    {
        SceneManager.LoadScene("Ending");
    }
}
