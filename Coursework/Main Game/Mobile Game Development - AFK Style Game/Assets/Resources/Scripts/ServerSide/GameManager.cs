using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    
    public static long dabloonsAmount;
    public static int perClick = 2;


    public TextMeshProUGUI DabloonsUI;

    public static int MultiplierAmount = 1; 

    public void Press()
    {
        dabloonsAmount = dabloonsAmount + perClick * MultiplierAmount;
        Debug.LogWarning(dabloonsAmount);
    }

    
    void Update()
    {
        
    }
}
