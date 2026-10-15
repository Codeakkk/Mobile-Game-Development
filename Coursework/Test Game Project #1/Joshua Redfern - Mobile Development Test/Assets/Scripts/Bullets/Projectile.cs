using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float bulletSpeed;

    private Transform core;
    private GameObject player;
    private Vector2 target;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Find player object
        player = GameObject.FindGameObjectWithTag("Player");

        //Find player core position and record last position
        core = GameObject.FindGameObjectWithTag("PlayerCore").transform;
        target = new Vector2(core.position.x, core.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        //Ignore player layer
        Physics2D.IgnoreLayerCollision(10, 10);


        //Move bullet to target
        transform.position = Vector2.MoveTowards(transform.position, target, bulletSpeed * Time.deltaTime);

        //If bullet reaches player core position, destroy bullet
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
            player.GetComponent<Health>().TakeDamage(1);

        }

        //Bullet lifetime
        Destroy(this.gameObject, 1.25f);

    }

    private void OnBecameInvisible()
    {
        DestroyProjectile();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCore"))
        {

            DestroyProjectile();
        }
    }

    void DestroyProjectile()
    {
        Destroy(this.gameObject);
    }

}
