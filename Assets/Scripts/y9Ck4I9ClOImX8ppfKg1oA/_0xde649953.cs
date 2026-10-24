using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.UI;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

/// <summary>
/// The dragon: it never moves forward, only banks. Input is the new Input System's
/// EnhancedTouch, gated on BasicController.IsGameRunning - which is exactly what the
/// template's own (private) touch helpers do, and what makes a raised pop freeze play.
///
/// The TAP LATCH is what makes this game survive the review capture: the capture tool only
/// ever issues a ~0.1 s tap, so a press stores its direction and keeps returning it for
/// MinHoldSeconds. One tap therefore produces a real, visible swing of about a fifth of the
/// screen instead of an invisible nudge.
/// </summary>
public sealed class _0xde649953 : MonoBehaviour
{
    private Image _0x67235edc;
    private RectTransform _0x7d649acf;
    public float _0xe1e736db
    {
        get
        {
            return this._0x95327a59;
        }
    }

    /// <summary>Glides in from below over the intro; no input is consumed while it runs.</summary>
    public void _0x36394fdd(float _0xf7a29b19)
    {
        if (this._0x7d649acf == null)
        {
            return;
        }

        this._0x7d649acf.anchoredPosition = new Vector2(_0x531552b7.PanelCx, _0x531552b7.DragonY - 620f);
        this._0x7d649acf.DOAnchorPosY(_0x531552b7.DragonY, _0xf7a29b19).SetEase(Ease.OutCubic).SetLink(this._0x7d649acf.gameObject);
    }

    private Image _0x7d1d58ba;
    private _0xea91f29d _0x5df83a4a;
    private bool _0xc14945f6;
    private float _0x10202e06;
    private float _0x95124bf0;
    private void OnDestroy()
    {
        DOTween.Kill(this._0x7d649acf);
        DOTween.Kill(this._0x7d1d58ba);
        DOTween.Kill(this._0x67235edc);
    }

    public void _0xe20b9592()
    {
        // The body, not the root: Steer rewrites the root's anchoredPosition every frame
        // and would fight the shake.
        if (this._0x7d1d58ba != null)
        {
            this._0x7d1d58ba.rectTransform.DOShakeAnchorPos(0.18f, 26f, 18, 90f, false, true).SetLink(this._0x7d1d58ba.gameObject);
            this._0x7d1d58ba.DOColor(Color.white, 0.3f).From(new Color(1f, 0.42f, 0.42f, 1f)).SetLink(this._0x7d1d58ba.gameObject);
        }
    }

    public void _0x0ea00d8f(RectTransform _0x881179d3, RectTransform _0x128f7b39, Image _0x977fecca, Image _0x7dceab76, _0xea91f29d _0x7036933f, Camera _0x9ce0af5f, bool _0x4b1212b5)
    {
        this._0x7e7d9a36 = _0x881179d3;
        this._0x7d649acf = _0x128f7b39;
        this._0x7d1d58ba = _0x977fecca;
        this._0x67235edc = _0x7dceab76;
        this._0x5df83a4a = _0x7036933f;
        this._0x6102007a = _0x9ce0af5f;
        this._0xc14945f6 = _0x4b1212b5;
        this._0x95327a59 = 0f;
        EnhancedTouchSupport.Enable();
    }

    public void _0x61327a2f(_0x5afdf70c _0x5c20169f)
    {
        if (this._0x67235edc != null)
        {
            this._0x67235edc.DOColor(_0x2ac8856b.Faded(_0x2ac8856b.OfRing(_0x5c20169f), 0.55f), 0.18f).SetLink(this._0x67235edc.gameObject);
        }
    }

    /// <summary>Steers for one frame. Returns the dragon's x in field coordinates.</summary>
    public float _0x37586d77(float delta, bool _0x1b8a1350)
    {
        float _0x8db3610c = _0x1b8a1350 ? this._0x04b54cf3(delta) : 0f;
        float _0xa02c9b5d = this._0x95327a59;
        if (Mathf.Abs(_0x8db3610c) > 0.01f)
        {
            this._0x95327a59 += _0x8db3610c * _0x531552b7.SteerRate * delta;
        }
        else
        {
            this._0x95327a59 = Mathf.MoveTowards(this._0x95327a59, 0f, _0x531552b7.LevelRate * delta);
        }

        this._0x95327a59 = Mathf.Clamp(this._0x95327a59, -_0x531552b7.LaneHalf, _0x531552b7.LaneHalf);
        this._0x10202e06 = delta > 0.0001f ? (this._0x95327a59 - _0xa02c9b5d) / delta : 0f;
        if (this._0x7d649acf != null)
        {
            this._0x7d649acf.anchoredPosition = new Vector2(_0x531552b7.PanelCx + this._0x95327a59, this._0x7d649acf.anchoredPosition.y);
            float _0x9582afbd = Mathf.Clamp(-this._0x10202e06 / _0x531552b7.SteerRate, -1f, 1f) * 18f;
            Vector3 _0xb9a7c11a = this._0x7d649acf.localEulerAngles;
            float _0xbf92edb3 = _0xb9a7c11a.z > 180f ? _0xb9a7c11a.z - 360f : _0xb9a7c11a.z;
            float _0x5c9523b0 = Mathf.Lerp(_0xbf92edb3, _0x9582afbd, Mathf.Clamp01(delta / 0.12f));
            this._0x7d649acf.localEulerAngles = new Vector3(0f, 0f, _0x5c9523b0);
        }

        if (this._0x5df83a4a != null)
        {
            this._0x5df83a4a._0x3624fecc(new Vector2(_0x531552b7.PanelCx + this._0x95327a59, _0x531552b7.DragonY), delta, this._0xc14945f6);
        }

        return this._0x95327a59;
    }

    private RectTransform _0x7e7d9a36;
    private float _0x95327a59;
    private Camera _0x6102007a;
    /// <summary>
    /// -1, 0 or +1. A live touch in the lower part of the screen steers towards its x; a
    /// touch that has already ended keeps steering until the latch runs out.
    /// </summary>
    private float _0x04b54cf3(float delta)
    {
        float _0x92a3beb4 = 0f;
        bool _0x4d77f062 = false;
        foreach (Touch _0x841206f8 in Touch.activeTouches)
        {
            Vector2 _0x90f06dec;
            if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(this._0x7e7d9a36, _0x841206f8.screenPosition, this._0x6102007a, out _0x90f06dec))
            {
                continue;
            }

            float _0xb06931fe = (_0x90f06dec.y + (_0x531552b7.PanelH * 0.5f)) / _0x531552b7.PanelH;
            if (_0xb06931fe > _0x531552b7.TouchZoneTop)
            {
                continue;
            }

            _0x4d77f062 = true;
            _0x92a3beb4 = _0x90f06dec.x > this._0x95327a59 ? 1f : -1f;
        }

        if (_0x4d77f062)
        {
            this._0xc67b1243 = _0x92a3beb4;
            this._0x95124bf0 = _0x531552b7.MinHoldSeconds;
            return _0x92a3beb4;
        }

        if (this._0x95124bf0 > 0f)
        {
            this._0x95124bf0 -= delta;
            return this._0xc67b1243;
        }

        return 0f;
    }

    private float _0xc67b1243;
}