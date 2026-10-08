using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playButton : MonoBehaviour
{
    public Button startButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton.onClick.AddListener(OnButtonPressed);
    }

    // Update is called once per frame
    void OnButtonPressed()
    {
        SceneManager.LoadScene("TimeToPlayTheGAME");
    }
}
