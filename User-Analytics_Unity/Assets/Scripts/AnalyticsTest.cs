using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnalyticsTest : MonoBehaviour
{
    public Button testButton;

    private void Start()
    {
        testButton.onClick.AddListener(() => { SceneManager.LoadScene("TestScene"); });
    }
}   