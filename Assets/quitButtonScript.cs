using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class quitButtonScript : MonoBehaviour
{
    public Button quittingButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        quittingButton.onClick.AddListener(OnButtonPressed);
    }

    // Update is called once per frame
    void OnButtonPressed()
    {
        Application.Quit();
    }
}
