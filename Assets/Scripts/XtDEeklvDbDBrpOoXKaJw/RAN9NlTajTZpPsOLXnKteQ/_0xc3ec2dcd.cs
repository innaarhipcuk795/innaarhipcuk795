using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xc3ec2dcd : MonoBehaviour
{
    private static Rect _0x0ce151ba = Rect.zero;
    private CanvasScaler _0xef36c2ba;
    private void Update()
    {
        if (_0x3b63254d.Count == 0 || _0x3b63254d[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x3ff7571e)
            OrientationChanged();
        if (Screen.safeArea != _0x0ce151ba)
            SafeAreaChanged();
        if (Screen.width != _0xe848c854.x || Screen.height != _0xe848c854.y)
            ResolutionChanged();
    }

    private RectTransform _0x18961ff0;
    private void Start()
    {
    }

    private static void ResolutionChanged()
    {
        _0xe848c854.x = Screen.width;
        _0xe848c854.y = Screen.height;
        _0x0ce151ba = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x28a64729.Invoke();
    }

    private Canvas _0x66bc746b;
    private Vector2 _0xf4bf6279;
    private static Vector2 _0xe848c854 = Vector2.zero;
    private static void SafeAreaChanged()
    {
        _0x0ce151ba = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private void _0x82677199()
    {
        if (this._0x18961ff0 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x813043a9 = Screen.safeArea;
        Vector2 _0xda61f202 = _0x813043a9.position;
        Vector2 _0xb2bdb161 = _0x813043a9.position + _0x813043a9.size;
        _0xda61f202.x /= screenWidth;
        _0xda61f202.y /= screenHeight;
        _0xb2bdb161.x /= screenWidth;
        _0xb2bdb161.y /= screenHeight;
        this._0x18961ff0.anchorMin = _0xda61f202;
        this._0x18961ff0.anchorMax = _0xb2bdb161;
        this._0x18961ff0.offsetMin = Vector2.zero;
        this._0x18961ff0.offsetMax = Vector2.zero;
        if (this._0xef36c2ba == null)
            return;
        Vector2 _0x34645d3e = _0xb2bdb161 - _0xda61f202;
        float _0xda8073f5 = 2f - _0x34645d3e.x;
        float _0xa2ba83e7 = 2f - _0x34645d3e.y;
        this._0xef36c2ba.referenceResolution = this._0xf4bf6279 * new Vector2(_0xda8073f5, _0xa2ba83e7);
    }

    private RectTransform _0x978b3c94;
    private static UnityEvent _0x28a64729 = new();
    private static void OrientationChanged()
    {
        _0x3ff7571e = Screen.orientation;
        _0xe848c854.x = Screen.width;
        _0xe848c854.y = Screen.height;
        _0x0ce151ba = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x28a64729.Invoke();
    }

    private static bool _0x9521e061;
    private void OnDestroy()
    {
        if (_0x3b63254d != null && _0x3b63254d.Contains(this))
            _0x3b63254d.Remove(this);
    }

    private static ScreenOrientation _0x3ff7571e = ScreenOrientation.LandscapeLeft;
    private static readonly List<_0xc3ec2dcd> _0x3b63254d = new();
    private void Awake()
    {
        if (!_0x3b63254d.Contains(this))
            _0x3b63254d.Add(this);
        this._0x66bc746b = this.GetComponent<Canvas>();
        this._0xef36c2ba = this.GetComponent<CanvasScaler>();
        if (this._0xef36c2ba != null)
            this._0xf4bf6279 = this._0xef36c2ba.referenceResolution;
        this._0x978b3c94 = this.GetComponent<RectTransform>();
        this._0x18961ff0 = this.transform.Find(_0xfd4c12ba._0x4c465dc7(new byte[8] { 118, 68, 67, 64, 100, 87, 64, 68 }, 37)) as RectTransform;
        if (!_0x9521e061)
        {
            _0x3ff7571e = Screen.orientation;
            _0xe848c854.x = Screen.width;
            _0xe848c854.y = Screen.height;
            _0x0ce151ba = Screen.safeArea;
            _0x9521e061 = true;
        }

        this._0x82677199();
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x196e3951 = 0; _0x196e3951 < _0x3b63254d.Count; _0x196e3951++)
            _0x3b63254d[_0x196e3951]._0x82677199();
    }
}

internal static class _0xfd4c12ba
{
    internal static string _0x4c465dc7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}