using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A settings toggle. State is shown three ways at once - fill colour, knob side and the
/// ON/OFF word beside the pill - so the tap is confirmed on a screenshot (C.7). The word
/// sits OUTSIDE the pill in Cream: a dark label on a gold fill would blend into the shared
/// dark outline (C.14).
/// </summary>
public sealed class _0x50225373 : MonoBehaviour
{
    private RectTransform _0x03cae902;
    public void _0x72c62e82(RectTransform _0x01a38335, _0xadc65cb2 _0x60878008, Vector2 _0x18ad603d, bool _0xf252498b)
    {
        RectTransform _0xe9c5db5c = _0x01a38335.parent as RectTransform;
        _0x29ecbd6a.Scrim(_0x01a38335, _0x47f1f2b8._0xa1bc665a(new byte[7] { 78, 119, 114, 114, 76, 119, 115 }, 30), _0x60878008.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.7f), false);
        this._0x94b36a94 = _0x29ecbd6a.Inset(_0x01a38335, _0x47f1f2b8._0xa1bc665a(new byte[8] { 7, 62, 59, 59, 17, 62, 59, 59 }, 87), 4f, _0x60878008.Plate, _0x2ac8856b.Deep, 0.55f);
        float _0x665f4941 = PillH - (KnobInset * 2f);
        this._0x03cae902 = _0x29ecbd6a.Node(_0x01a38335, _0x47f1f2b8._0xa1bc665a(new byte[8] { 227, 218, 223, 223, 248, 221, 220, 209 }, 179), new Vector2(KnobInset + (_0x665f4941 * 0.5f), PillH * 0.5f), _0x531552b7.Square(_0x665f4941));
        _0x29ecbd6a.Scrim(this._0x03cae902, _0x47f1f2b8._0xa1bc665a(new byte[8] { 28, 57, 56, 53, 17, 54, 52, 50 }, 87), _0x60878008.Plate, _0x2ac8856b.Cream, false);
        this._0x47d92c4e = _0x29ecbd6a.Label(_0xe9c5db5c, _0x47f1f2b8._0xa1bc665a(new byte[8] { 108, 85, 80, 80, 107, 83, 78, 88 }, 60), new Vector2(_0x18ad603d.x + (PillW * 0.5f) + 86f, _0x18ad603d.y), new Vector2(100f, 56f), _0x60878008, _0x47f1f2b8._0xa1bc665a(new byte[3] { 174, 167, 167 }, 225), _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 42f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
        this._0xdac245ea = _0x29ecbd6a.Tap(this._0x94b36a94);
        this._0xbdf4c35a(_0xf252498b, false);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this._0x03cae902);
    }

    public Button _0xc1aaacdb
    {
        get
        {
            return this._0xdac245ea;
        }
    }

    private bool _0xcafe3495;
    private Button _0xdac245ea;
    private Image _0x94b36a94;
    private const float PillH = 88f;
    public void _0xbdf4c35a(bool _0x75df7ab6, bool _0x2649d43f)
    {
        this._0xcafe3495 = _0x75df7ab6;
        float _0xc8294d4f = PillH - (KnobInset * 2f);
        float _0x7d1f4d83 = _0x75df7ab6 ? PillW - KnobInset - (_0xc8294d4f * 0.5f) : KnobInset + (_0xc8294d4f * 0.5f);
        if (this._0x94b36a94 != null)
        {
            this._0x94b36a94.color = _0x75df7ab6 ? _0x2ac8856b.Gold : _0x2ac8856b.Deep;
        }

        if (this._0x47d92c4e != null)
        {
            _0x6bdb9d59.SetText(this._0x47d92c4e, _0x75df7ab6 ? _0x47f1f2b8._0xa1bc665a(new byte[2] { 190, 191 }, 241) : _0x47f1f2b8._0xa1bc665a(new byte[3] { 95, 86, 86 }, 16));
            this._0x47d92c4e.color = _0x75df7ab6 ? _0x2ac8856b.Gold : _0x2ac8856b.Muted;
        }

        if (this._0x03cae902 == null)
        {
            return;
        }

        if (_0x2649d43f)
        {
            this._0x03cae902.DOAnchorPosX(_0x7d1f4d83, 0.14f).SetEase(Ease.OutQuad).SetLink(this._0x03cae902.gameObject);
        }
        else
        {
            this._0x03cae902.anchoredPosition = new Vector2(_0x7d1f4d83, PillH * 0.5f);
        }
    }

    public bool _0x831c2632
    {
        get
        {
            return this._0xcafe3495;
        }
    }

    private const float PillW = 220f;
    private TextMeshProUGUI _0x47d92c4e;
    private const float KnobInset = 8f;
}

internal static class _0x47f1f2b8
{
    internal static string _0xa1bc665a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}