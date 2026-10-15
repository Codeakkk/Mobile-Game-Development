using UnityEngine;

public class despawn : MonoBehaviour
{
    public GameObject enemie;

    
    private void OnBecameInvisible()
    {
        Debug.Log(gameObject.name + "destroying object");
       //Destroy once not on screen anymore
        Destroy(this.gameObject);
    } 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    

}
