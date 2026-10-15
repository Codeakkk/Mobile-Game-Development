using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class Bullet : MonoBehaviour
{

    public GameObject player;

    public Vector2 direction = new Vector2(1, 0);
    public Vector2 velocity;
    public float speed = 20f;
    public int score;

    [SerializeField] private AudioClip enemyExplodeSFX;

    Animator anim;
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
            SoundManager.instance.PlaySound(enemyExplodeSFX);
            Destroy(this.gameObject);
            Destroy(collision.gameObject, 0.3f);

            player.GetComponent<PlayerMovement>().score++;
        }


        if (gameObject.tag == "Player")
        {
            Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
        }
        Destroy(this.gameObject);
    }

    void Update()
    {
        velocity = direction * speed;
        score = player.GetComponent<PlayerMovement>().score;
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
    }

    
}
