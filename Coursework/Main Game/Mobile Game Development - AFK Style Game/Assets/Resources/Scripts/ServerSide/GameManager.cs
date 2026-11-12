using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    
    public static long dabloonsAmount;
    public static int perClick = 2;
    public static int PlayerCharacters = 1;
    public double timer;

    public static double MultiplierAmount = 1;

    [Header("UI")]
    public TextMeshProUGUI DabloonsUI;

    public void FirstMultiplier()
    {
        if (dabloonsAmount >= 5000)
        {
            if (PlayerCharacters > 5)
            {
                MultiplierAmount = MultiplierAmount + 0.15;
                dabloonsAmount = dabloonsAmount - 5000;
            } else
            {
                Debug.LogWarning("Player Has Exceeded Character Limit");
            }

        }


    }

    public void SecondMultiplier()
    {
        if (dabloonsAmount >= 10000)
        {
            if (PlayerCharacters > 5)
            {
                MultiplierAmount = MultiplierAmount + 0.25;
                dabloonsAmount = dabloonsAmount - 5000;
            }
            else
            {
                Debug.LogWarning("Player Has Exceeded Character Limit");
            }

        }


    }




    public void Press()
    {
        dabloonsAmount = dabloonsAmount + (long)(perClick * MultiplierAmount);
        Debug.LogWarning(dabloonsAmount);
    }

    public void UpdateUI()
    {
        DabloonsUI.text = dabloonsAmount.ToString();
    }
    
    void Update()
    {
        UpdateUI();

        timer += Time.deltaTime;

        if (timer > 0.5)
        {
            dabloonsAmount = dabloonsAmount + 1 * PlayerCharacters;
            timer -= 0.5;
        }
    }
}
