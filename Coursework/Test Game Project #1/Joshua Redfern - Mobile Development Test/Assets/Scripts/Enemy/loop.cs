using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SocialPlatforms.Impl;


public class loop : MonoBehaviour
{
    public GameObject[] enemies;
    public float enemieInterval;
    public GameObject player;

    public int playerScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        GameObject enemy = enemies[Random.Range(0, enemies.Length)];
        StartCoroutine(spawnEnemy(enemieInterval));

    }

    private IEnumerator spawnEnemy(float interval)
    {
        //Decrease interval time every 10 points, minimum of 1.5 seconds
        if (playerScore != 0 && playerScore % 10 == 0 && enemieInterval > 0.8f)
        {
            enemieInterval -= 0.2f;

            //Increase score to avoid multiple intervals
            playerScore = player.GetComponent<PlayerMovement>().score++;
        }


        interval = enemieInterval;
        yield return new WaitForSeconds(interval);

        GameObject enemy = enemies[Random.Range(0, enemies.Length)];

        //Create enemy if not sine wave enemy
        if (enemy.name == "Enemy_Sine")
        {
            GameObject newEnemy = Instantiate(enemy, new Vector3(8.75f, -3f, 0), Quaternion.identity);
        }
        else if (enemy.name == "Enemy_Basic")
        {
            GameObject newEnemy = Instantiate(enemy, new Vector3(8.75f, Random.Range(-6.5f, -0.25f), 0), Quaternion.identity);
        }


        StartCoroutine(spawnEnemy(enemieInterval));
    }
    void OnBecomeInvisible()
    {
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        playerScore = player.GetComponent<PlayerMovement>().score;
    }

}
