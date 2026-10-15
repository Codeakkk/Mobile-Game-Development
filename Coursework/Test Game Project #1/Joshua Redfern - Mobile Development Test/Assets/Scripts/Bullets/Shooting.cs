using System.Collections;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public bool CanShoot = true;
    public GameObject BulletPrefab;
    public Transform FireFrom;
    public Bullet bullet;

    public float timeToShoot = 1f;
    public float timeshoot;
    public float BulletSpeed = 15f;

    public Rigidbody2D rb;

    [SerializeField] private AudioClip playerShootSFX;

    void Start()
    {

    }

    void Update()
    {

        timeshoot += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        
        if (timeToShoot < timeshoot)
        {
            SoundManager.instance.PlaySound(playerShootSFX);
            GameObject Bullet = Instantiate(bullet.gameObject, FireFrom.position, transform.rotation);
            Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(FireFrom.right * BulletSpeed * Time.deltaTime, ForceMode2D.Impulse);
            timeshoot = 0;
        }
    }
}


