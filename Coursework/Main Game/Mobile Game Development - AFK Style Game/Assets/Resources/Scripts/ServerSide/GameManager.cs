using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    
    public static long dabloonsAmount;
    public static int perClick = 2;



    public static int MultiplierAmount = 1;

    [Header("UI")]
    public TextMeshProUGUI DabloonsUI;

    public void Press()
    {
        dabloonsAmount = dabloonsAmount + perClick * MultiplierAmount;
        Debug.LogWarning(dabloonsAmount);
    }

    public void UpdateUI()
    {
        DabloonsUI.text = dabloonsAmount.ToString();
    }
    
    void Update()
    {
        UpdateUI();
    }
}
