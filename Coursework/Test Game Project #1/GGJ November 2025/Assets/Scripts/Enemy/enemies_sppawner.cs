using System.Collections;
using UnityEngine;


public class enemies_sppawner : MonoBehaviour
{
    public GameObject[] enemie;
    public float width = 10f;
    public int enemiesPerRow = 5;

    public float enemieInterval = 3.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < enemiesPerRow; i++)
        {
         float offset = (i * width) / (enemiesPerRow - 1);
        Vector3 spawnPoint = transform.position + offset * Vector3.right;
            int enemyIdx = Random.Range(0, enemie.Length);
            Instantiate(enemie[enemyIdx], spawnPoint, Quaternion.identity);
        }
    }


    


     

    // Update is called once per frame
    void Update()
    {
        
    }
}

