using Unity.Services.Analytics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnalyticsExample : MonoBehaviour
{
    void Start()
    {
        AnalyticsService.Instance.RecordEvent(new SceneChangeEvent("SceneChangeEvent")
        {
            SceneName = SceneManager.GetActiveScene().name
        });

        AnalyticsService.Instance.Flush();

        Debug.Log($"Custom event {SceneManager.GetActiveScene().name} sent.");
    }
}