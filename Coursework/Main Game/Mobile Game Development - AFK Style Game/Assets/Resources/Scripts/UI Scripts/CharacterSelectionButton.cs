using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionButton : MonoBehaviour
{
    [SerializeField] private GameObject IOSHaptic;

    public void CharacterSelectionScene()
    {
        IOSHaptic.GetComponent<IOSHaptics>().PlayImpact(ImpactStyle.Medium);
        SceneManager.LoadScene("CharacterSelections");
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
