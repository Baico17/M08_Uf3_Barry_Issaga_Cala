using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{

    private int  numbTouch = 1;
    void Update()
    {
        if(Input.touchCount == 1)
        {
            SceneManager.LoadScene(1);
        }

        if (Input.touchCount == 2)
        {
            Application.Quit();
        }
    }
}
