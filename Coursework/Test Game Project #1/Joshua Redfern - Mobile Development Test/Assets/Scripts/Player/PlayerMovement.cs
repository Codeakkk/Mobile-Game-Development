using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    [Header("Player Physical Attributes")]
    public int moveSpeed = 5;
    

    [Header("Game Attributes")]
    public int score;

    Rigidbody2D rb;
    Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector2(hInput * moveSpeed, vInput * moveSpeed);

        //Movement animations
        if (hInput != 0)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }

        //Going up/down animations
        if (vInput > 0)
        {
            //If the player is going up
            anim.SetBool("goingUp", true);
            anim.SetBool("goingDown", false);
        }
        else if (vInput < 0)
        {
            //If the player is going down
            anim.SetBool("goingUp", false);
            anim.SetBool("goingDown", true);
        }
        else
        {
            //Neither going up or down
            anim.SetBool("goingUp", false);
            anim.SetBool("goingDown", false);
        }

        //Restrict player to screen bounds
        RestrictToScreenBounds();


        //Score Debug
        if (Input.GetKeyDown(KeyCode.P))
        {
            score+=1;
        }

        scoreText.text = "Score: " + score;
    }

    public void RestrictToScreenBounds()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
