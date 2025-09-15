public class SceneChangeEvent : Unity.Services.Analytics.Event
{
    public SceneChangeEvent(string name) : base(name)
    {
    }

    public string SceneName
    {
        set { SetParameter("SceneName", value); }
    }
}
/*
 * OnQRSCanned
 * WorkLisiting
 * Loglistiing
 * On WOrk INteratd
 * on ogInteracte
 */