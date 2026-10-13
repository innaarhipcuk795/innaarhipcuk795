using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x2acc3eea : MonoBehaviour
{
    private RectTransform _0x03d2dbc1;
    private static UnityEvent _0x2ed52712 = new();
    private void Update()
    {
        if (_0x6a77fe13[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x4f5de665)
            OrientationChanged();
        if (Screen.safeArea != _0xe34b110a)
            SafeAreaChanged();
        if (Screen.width != _0x092f0713.x || Screen.height != _0x092f0713.y)
            ResolutionChanged();
    }

    private static bool _0xda920088;
    private static void ResolutionChanged()
    {
        _0x092f0713.x = Screen.width;
        _0x092f0713.y = Screen.height;
        _0x2ed52712.Invoke();
    }

    private void _0x7a5670fa()
    {
        if (this._0x03d2dbc1 == null)
            return;
        Rect _0x46c29eb4 = Screen.safeArea;
        Vector2 _0xf6f6a753 = _0x46c29eb4.position;
        Vector2 _0xd0f49bfd = _0x46c29eb4.position + _0x46c29eb4.size;
        _0xf6f6a753.x /= this._0x6520983f.pixelRect.width;
        _0xf6f6a753.y /= this._0x6520983f.pixelRect.height;
        _0xd0f49bfd.x /= this._0x6520983f.pixelRect.width;
        _0xd0f49bfd.y /= this._0x6520983f.pixelRect.height;
        this._0x03d2dbc1.anchorMin = _0xf6f6a753;
        this._0x03d2dbc1.anchorMax = _0xd0f49bfd;
    }

    private RectTransform _0xc9c91cf6;
    private void OnDestroy()
    {
        if (_0x6a77fe13 != null && _0x6a77fe13.Contains(this))
            _0x6a77fe13.Remove(this);
    }

    private static void SafeAreaChanged()
    {
        _0xe34b110a = Screen.safeArea;
        for (int _0xab100378 = 0; _0xab100378 < _0x6a77fe13.Count; _0xab100378++)
            _0x6a77fe13[_0xab100378]._0x7a5670fa();
    }

    private static Rect _0xe34b110a = Rect.zero;
    private void Awake()
    {
        if (!_0x6a77fe13.Contains(this))
            _0x6a77fe13.Add(this);
        this._0x6520983f = this.GetComponent<Canvas>();
        this._0xc9c91cf6 = this.GetComponent<RectTransform>();
        this._0x03d2dbc1 = this.transform.Find(_0x29e3a0bd._0x896b951b(new byte[8] { 33, 19, 20, 23, 51, 0, 23, 19 }, 114)) as RectTransform;
        if (!_0xda920088)
        {
            _0x4f5de665 = Screen.orientation;
            _0x092f0713.x = Screen.width;
            _0x092f0713.y = Screen.height;
            _0xe34b110a = Screen.safeArea;
            _0xda920088 = true;
        }

        this._0x7a5670fa();
    }

    private static ScreenOrientation _0x4f5de665 = ScreenOrientation.LandscapeLeft;
    private static Vector2 _0x092f0713 = Vector2.zero;
    private static void OrientationChanged()
    {
        _0x4f5de665 = Screen.orientation;
        _0x092f0713.x = Screen.width;
        _0x092f0713.y = Screen.height;
        _0x2ed52712.Invoke();
    }

    private Canvas _0x6520983f;
    private static readonly List<_0x2acc3eea> _0x6a77fe13 = new();
}

internal static class _0x29e3a0bd
{
    internal static string _0x896b951b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}