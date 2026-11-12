using UnityEngine;
using UnityEngine.SceneManagement;

public class TavernShopButton : MonoBehaviour
{

    public void TavernScene()
    {
        SceneManager.LoadScene("TavernShops");
    }

    public void ShopScene()
    {
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
