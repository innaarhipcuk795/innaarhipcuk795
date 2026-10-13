using UnityEngine;

public class _0xf6d99b66 : MonoBehaviour
{
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xf6d99b66>();
            DontDestroyOnLoad(this.gameObject);
            this._0xc4fbf714();
        }
        else
        {
            this._0x2dd7a777();
            Destroy(this.gameObject);
        }
    }

    public bool IsLevelSelectorEnabled;
    public bool IsStoryEnabled;
    public bool IsTutorialEnabled;
    private void _0x2dd7a777()
    {
    }

    public bool IsSkipSplashEnabled;
    public static _0xf6d99b66 Instance;
    public bool IsLevelIncrementOnWin;
    private void _0xc4fbf714()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsCheckScoreEnabled;
    public bool IsTimerEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsBestScoreEnabled;
}