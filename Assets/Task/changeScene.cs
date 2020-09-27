using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void fasterView()
    {
        SceneManager.LoadScene("FasterScene");
    }

    public void easierView()
    {
        SceneManager.LoadScene("EasierScene");
    }

    public void saferView()
    {
        SceneManager.LoadScene("SaferScene");
    }
    //whole of faster



}
