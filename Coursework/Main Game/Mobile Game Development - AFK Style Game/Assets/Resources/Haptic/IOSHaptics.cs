using UnityEngine;
using System.Runtime.InteropServices;

public class IOSHaptics : MonoBehaviour
{
#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void _PlayImpact(int style);

    [DllImport("__Internal")]
    private static extern void _PlayNotification(int type);

    [DllImport("__Internal")]
    private static extern void _PlaySelection();
#endif

    public void PlayImpact(ImpactStyle style)
    {
#if UNITY_IOS && !UNITY_EDITOR
        _PlayImpact((int)style);
#endif
    }

    public void PlayNotification(NotificationType type)
    {
#if UNITY_IOS && !UNITY_EDITOR
        _PlayNotification((int)type);
#endif
    }

    public void PlaySelection()
    {
#if UNITY_IOS && !UNITY_EDITOR
        _PlaySelection();
#endif
    }
}

public enum ImpactStyle
{
    Light = 0,
    Medium = 1,
    Heavy = 2,
    Soft = 3,
    Rigid = 4
}

public enum NotificationType
{
    Success = 0,
    Warning = 1,
    Error = 2
}