using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LoseManagerUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public Health health;
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
        score = player.GetComponent<PlayerMovement>().score;
        scoreText.text = "Final Score: " + score;

    }

    public void RestartBtn()
    {
        SceneManager.LoadScene("Level 0");
    }

    public void QuitBtn()
    {
        Application.Quit();
    }
}
