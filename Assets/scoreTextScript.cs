using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class scoreTextScript : MonoBehaviour
{
    [SerializeField] private basketIdentification basketScore;
    [SerializeField] private TextMeshProUGUI textScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int ScoreScore = basketScore.score;
        textScore.text = "Score: " + ScoreScore;
    }
}
