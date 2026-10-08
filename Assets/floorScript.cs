using UnityEngine;
using UnityEngine.SceneManagement;

public class floorScript : MonoBehaviour
{
    [SerializeField] private basketIdentification playerHealthInfo;
    [SerializeField] private basketIdentification GameOver;

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("normalCoin"))
        {
            int healthCount = playerHealthInfo.playerHealth;
            playerHealthInfo.playerHealth--;
            Destroy(other.gameObject);
            if (playerHealthInfo.playerHealth <= 0)
            {
                GameFloover();
            }
        }
        if (other.gameObject.CompareTag("megaCoin"))
        {
            playerHealthInfo.playerHealth--;
            Destroy(other.gameObject);
            if (playerHealthInfo.playerHealth <= 0)
            {
                GameFloover();
            }
        }
        if (other.gameObject.CompareTag("healthPack"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Bomb"))
        {
            Destroy(other.gameObject);
        }
    }
    public void GameFloover()
    {
        SceneManager.LoadScene("gameOverScreen");
    }
        
}