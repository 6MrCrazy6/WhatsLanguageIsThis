using UnityEngine;

public class Setting : MonoBehaviour
{

    public void clear()
    {
        if (PlayerPrefs.HasKey("BestScore"))
        {
            PlayerPrefs.DeleteKey("BestScore");
        }

        else
        {
            Debug.Log("No data");
        }
    }
}
