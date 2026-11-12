using UnityEngine;
using UnityEngine.SceneManagement;

public class TavernShopButton : MonoBehaviour
{
    [SerializeField] private GameObject IOSHaptic;
    public void TavernScene()
    {
        IOSHaptic.GetComponent<IOSHaptics>().PlayImpact(ImpactStyle.Medium);
        SceneManager.LoadScene("TavernShops");
    }

    public void ShopScene()
    {
        IOSHaptic.GetComponent<IOSHaptics>().PlayImpact(ImpactStyle.Medium);
        SceneManager.LoadScene("CharShop");
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
