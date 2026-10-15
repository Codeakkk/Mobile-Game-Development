using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Enemy_SineMovement : MonoBehaviour
{

    // Sinewave properties

    //Height of the sinewave and movement speed of the object on it

    [Header("Sinewave Properties")]
    public float amplitude = 0.5f;
    public float frequency = 2f;

    float sineCentreY;

    [Header("Enemy Properties")]
    //Enemy properties
    public float enemySpeed;



    Rigidbody2D rb;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        sineCentreY = transform.position.y;
    }
    

    // Update is called once per frame
    void Update()
    {
        //Move from right to left
        rb.linearVelocityX = -enemySpeed;

        //Sinewave movement
        float sinMovement = amplitude * Mathf.Sin(Time.time * frequency);
        transform.position = new Vector3(transform.position.x, sineCentreY + sinMovement, transform.position.z);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
