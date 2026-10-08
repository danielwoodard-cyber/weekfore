using UnityEngine;
using UnityEngine.SceneManagement;
public class basketIdentification : MonoBehaviour
{
    public int playerHealth = 5;
    public int maxPlayerHealth = 5;
    public int score = 0;
    [SerializeField] private int coinValue = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("normalCoin"))
        {
            score += 10;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("megaCoin"))
        {
            score += 50;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("healthPack"))
        {
            playerHealth++;
            Destroy(other.gameObject);
            if (playerHealth > maxPlayerHealth)
            {
                playerHealth = maxPlayerHealth;
            }
        }
        if (other.gameObject.CompareTag("Bomb"))
        {
            playerHealth--;
            Destroy(other.gameObject);
            if (playerHealth <= 0)
            {
                GameOver();
            }
        }

        void GameOver()
        {
            SceneManager.LoadScene("gameOverScreen");
        }
    }
}