using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{


    public long dabloonsAmount;
    public int perClick = 2;


    public TextMeshProUGUI DabloonsUI;

    public int MultiplierAmount = 1; 

    public void Press()
    {
        dabloonsAmount = dabloonsAmount + perClick * MultiplierAmount;
    }

    
    void Update()
    {
        
    }
}
