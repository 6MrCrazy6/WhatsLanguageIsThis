using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Logic : MonoBehaviour
{
    private int count;
    private int bestscore;
    public GameObject loseTextObject;

    public Button firstbutton;
    public Button secondbutton;
    public Button thirdbutton;

    public TextMeshProUGUI countText;
    public TextMeshProUGUI score;
    public TextMeshProUGUI bestscores;

    void Awake()
    {
        if (!PlayerPrefs.HasKey("Count"))
        {
            PlayerPrefs.SetInt("Count", 0);
        }

        if (!PlayerPrefs.HasKey("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", 0);
        }
    }
    void Start()
    {
        count = PlayerPrefs.GetInt("Count");
        countText.text = "Count: " + count.ToString();
    }
    public void TrueVar()
    {
        count++;
        PlayerPrefs.SetInt("Count", count);
        int RandomQuestion = Random.Range(1, 21);
        SceneManager.LoadScene("Question " + RandomQuestion);
    }
    public void FalseVar()
    {
        loseTextObject.SetActive(true);
        count = PlayerPrefs.GetInt("Count");
        score.text = "Score: " + count.ToString();
        bestscore = PlayerPrefs.GetInt("BestScore");
        if (count > bestscore)
        {
            bestscore = count;
            PlayerPrefs.SetInt("BestScore", bestscore);
        }
        bestscores.text = "Best score:" + bestscore.ToString();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        PlayerPrefs.DeleteKey("Count");
    }
}
