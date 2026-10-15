using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class GameManagerUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject player;
    public int score;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = player.GetComponent<PlayerMovement>().score;
    }

    // Update is called once per frame
    void Update()
    {

        // Update the score 
        scoreText.text = "Score: " + player.GetComponent<PlayerMovement>().score;
    }
}
