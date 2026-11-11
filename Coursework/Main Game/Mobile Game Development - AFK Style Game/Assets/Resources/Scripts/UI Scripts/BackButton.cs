using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{


    public void BackScene()
    {
        SceneManager.LoadScene("OpeningUI");
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
