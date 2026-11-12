using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    [SerializeField] private GameObject IOSHaptic;

    public void BackScene()
    {
        IOSHaptic.GetComponent<IOSHaptics>().PlayImpact(ImpactStyle.Medium);
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
