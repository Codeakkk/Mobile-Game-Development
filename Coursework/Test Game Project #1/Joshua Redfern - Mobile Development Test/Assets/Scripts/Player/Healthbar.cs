using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
    public Health playerHealth;
    public Image totalHealthbar;
    public Image currentHealthbar;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalHealthbar.fillAmount = playerHealth.currentHealth / 10;
    }

    // Update is called once per frame
    void Update()
    {
        //Update healthbar fill amount based on player's current health
        currentHealthbar.fillAmount = playerHealth.currentHealth / 10;
    }
}
