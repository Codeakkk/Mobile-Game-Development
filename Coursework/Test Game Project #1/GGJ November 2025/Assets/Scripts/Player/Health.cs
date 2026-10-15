using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.Member;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;

    public GameObject enemy;

    //This can be set only in this script, but others can get it
    public float currentHealth  { get; private set; }

    public GameObject loseUI;
    public GameObject mainGameUI;

    private SpriteRenderer spriteRend;

    //Player states
    public bool playerisdead;

    Animator anim;
    [SerializeField] private AudioClip playerHitSFX;
    [SerializeField] private AudioClip playerExplodeSFX;
    private void Awake()
    {
        spriteRend = GetComponent<SpriteRenderer>();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();

        currentHealth = startingHealth;

        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            TakeDamage(1);
        }

        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if(currentHealth > 0)
        {
            SoundManager.instance.PlaySound(playerHitSFX);
            // Player hit?
            StartCoroutine(Invulnerability());
        }
        else
        {
            // If the player is dead
            if (!playerisdead)
            {
                //Destroy the player
                StartCoroutine(playerKiller());  
            }
            
        }
    }


    //Coroutine to manage player death
    IEnumerator playerKiller()
    {
        //Die and stop moving
        GetComponent<PlayerMovement>().moveSpeed = 0;
        
        SoundManager.instance.PlaySound(playerExplodeSFX);
        anim.SetTrigger("isDead");

        GetComponent<PlayerMovement>().enabled = false;

        enemy.GetComponent<EnemyBulletScript>().enabled = false;

        //Wait for 2 seconds
        yield return new WaitForSecondsRealtime(1);

        //Set to true so it's not repeated.
        playerisdead = true;

        gameObject.SetActive(false);

        //Hide game UI, show menu.
        loseUI.SetActive(true);
        mainGameUI.SetActive(false);
    }

    //Coroutine to manage player invulnerability
    private IEnumerator Invulnerability()
    {
        //Player ignores enemy
        Physics2D.IgnoreLayerCollision(10, 11, true);
        GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSecondsRealtime(0.5f);
        //loop and disable sprite rendering to flash 
        for (int i = 0; i < 3; i++)
        {
            //Flash on
            spriteRend.color = new Color(255, 255, 255, 1f);
            yield return new WaitForSecondsRealtime(0.25f);
            
            //Flash off
            spriteRend.color = Color.white;
            yield return new WaitForSecondsRealtime(0.25f);

        }
        Physics2D.IgnoreLayerCollision(10, 11, false);
        GetComponent<BoxCollider2D>().enabled = true;
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
}
