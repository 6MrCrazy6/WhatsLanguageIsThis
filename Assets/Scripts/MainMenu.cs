using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        int RandomQuestion = Random.Range(1, 21);
        SceneManager.LoadScene("Question " + RandomQuestion);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
