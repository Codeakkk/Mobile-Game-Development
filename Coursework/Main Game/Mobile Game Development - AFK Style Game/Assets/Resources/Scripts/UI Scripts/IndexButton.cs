using UnityEngine;
using UnityEngine.SceneManagement;

public class IndexButton : MonoBehaviour
{
    [SerializeField] private GameObject IOSHaptic;

    public void IndexScene()
    {
        IOSHaptic.GetComponent<IOSHaptics>().PlayImpact(ImpactStyle.Medium);
        SceneManager.LoadScene("Index");
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
