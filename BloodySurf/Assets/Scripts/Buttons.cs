using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void LoadScene(string name)
    {        

        SceneManager.LoadScene(name);        

    }

    public void QuitGame()
    {
        Application.Quit();

    }

}