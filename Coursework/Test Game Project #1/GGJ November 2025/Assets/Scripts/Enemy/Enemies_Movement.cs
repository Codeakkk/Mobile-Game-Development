using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Enemies_Movement : MonoBehaviour
{
    public GameObject enemie;
    public float stepMovement = 1.0f;
    public float horzSteps = 1.0f;
    public float stepTime = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StepBasedMovement());
    }
    IEnumerator StepBasedMovement()
    {
        while (true)
        {
            for (int i = 1; i < horzSteps; i++)
            {
                transform.position += Vector3.right * stepMovement;
                yield return new WaitForSeconds(0.05f);

            }
            transform.position += Vector3.left * stepMovement;
            yield return new WaitForSeconds(0.05f);

            for (int i = 1; i < stepTime; i++)
            {
                transform.position += Vector3.down * stepMovement;
                yield return new WaitForSeconds(0.05f);
            }
            transform.position += Vector3.left * stepMovement;
            yield return new WaitForSeconds(0.05f);
        }
    }

    
}
