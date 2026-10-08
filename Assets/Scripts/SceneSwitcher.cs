using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : Singleton<SceneSwitcher>   
{

    public void CheckAndLoadScene()
    {
        if (SceneManager.GetActiveScene().name == ("SampleScene"))
        {
            SceneManager.LoadScene("Scene2");

        }
        else if (SceneManager.GetActiveScene().name == ("Scene2"))
        {
            SceneManager.LoadScene("SampleScene");

        }

   
    }
}
