
using UnityEngine;

public class ItemManager : MonoBehaviour
{

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    public void GetItem()
    {
        gameManager.AddScore(100);
        Destroy(this.gameObject);
    }
}
