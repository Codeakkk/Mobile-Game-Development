using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public float randomNumber;
    public float shootDelay;
    public bool playerDead;
    public GameObject player;

    public GameObject projectile;

    [SerializeField] private AudioClip enemyShootSFX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomNumber = Random.Range(2, 4);

        player = GameObject.Find("Player");

        playerDead = player.GetComponent<Health>().playerisdead;

    }

    // Update is called once per frame
    void Update()
    {
        
        playerDead = player.GetComponent<Health>().playerisdead;

        shootDelay += Time.deltaTime;

        if(shootDelay > randomNumber)
        {
            if (!playerDead)
            {
                shootDelay = 0;
                SoundManager.instance.PlaySound(enemyShootSFX);
                Instantiate(projectile, transform.position, Quaternion.identity);
            }
        }
    }
}
