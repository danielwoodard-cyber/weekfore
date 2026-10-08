using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class healthTextScript : MonoBehaviour
{
    [SerializeField] private basketIdentification basketHealth;
    [SerializeField] private TextMeshProUGUI textHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        int Health = basketHealth.playerHealth;
        textHealth.text = "Health: " + Health;
    }
}
