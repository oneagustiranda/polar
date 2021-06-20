using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    public void Mulai()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Exit()
    {
        Debug.Log("exitApps");
        Application.Quit();
    }
}
