using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The run HUD, built from our OWN objects - nothing of ours hangs on a template slot.
///
/// The three x-bands are reserved so text and the charge orb never share one (C.25):
///   gate label 120..520 | orb 561..681 | score 722..1122, gaps of 41 units.
/// </summary>
public sealed class _0x8c355c33 : MonoBehaviour
{
    private TextMeshProUGUI _0x684a0a95;
    private Image _0xb9890891;
    private const float BarWidth = 960f;
    public void _0xced1fb8d(_0x5afdf70c _0xbb3af470)
    {
        if (this._0xb9890891 != null)
        {
            this._0xb9890891.DOColor(_0x2ac8856b.OfRing(_0xbb3af470), 0.18f).SetLink(this._0xb9890891.gameObject);
        }
    }

    private const float BarInset = 7f;
    private const float PillCy = 2035f;
    private TextMeshProUGUI _0xb9e261d5;
    private const float RowCy = 2235f;
    private TextMeshProUGUI _0x122a2905;
    public void _0x25215d56(bool _0xfcb284f3)
    {
        if (_0xfcb284f3 || this._0xb9890891 == null)
        {
            return;
        }

        this._0xb9890891.DOFade(0.62f, 0.9f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._0xb9890891.gameObject);
    }

    private const float BarCy = 2130f;
    public void _0x7915fbf6(int _0x3eed82ca, int _0x6c44ee39)
    {
        _0x6bdb9d59.SetText(this._0x684a0a95, _0x55236a9c._0xdd784b47(new byte[5] { 120, 126, 107, 122, 31 }, 63) + _0x3eed82ca.ToString(_0x55236a9c._0xdd784b47(new byte[2] { 126, 126 }, 78)) + _0x55236a9c._0xdd784b47(new byte[3] { 208, 223, 208 }, 240) + _0x6c44ee39.ToString(_0x55236a9c._0xdd784b47(new byte[2] { 242, 242 }, 194)));
    }

    private void OnDestroy()
    {
        DOTween.Kill(this._0xb9890891);
        DOTween.Kill(this._0xc3d03dbf);
        if (this._0x29a5ebb0 != null)
        {
            DOTween.Kill(this._0x29a5ebb0.rectTransform);
        }
    }

    public void _0xdf1e055d(RectTransform _0xd06d5c2f, _0xadc65cb2 _0x20ea0d2f)
    {
        _0x29ecbd6a.Card(_0xd06d5c2f, _0x55236a9c._0xdd784b47(new byte[7] { 130, 191, 174, 137, 171, 184, 174 }, 202), new Vector2(_0x531552b7.PanelCx, CardCy), new Vector2(1020f, 310f), _0x20ea0d2f.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Deep, 0.9f), _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.65f), 1.35f, 5f);
        this._0x684a0a95 = _0x29ecbd6a.Label(_0xd06d5c2f, _0x55236a9c._0xdd784b47(new byte[9] { 69, 99, 118, 103, 78, 99, 96, 103, 110 }, 2), new Vector2(320f, RowCy), new Vector2(400f, 72f), _0x20ea0d2f, _0x55236a9c._0xdd784b47(new byte[12] { 136, 142, 155, 138, 239, 255, 254, 239, 224, 239, 254, 247 }, 207), _0x531552b7.SizeBody, _0x531552b7.SizeBodyMin, 48f, _0x2ac8856b.Sky, TextAlignmentOptions.Left);
        this._0xb9e261d5 = _0x29ecbd6a.Label(_0xd06d5c2f, _0x55236a9c._0xdd784b47(new byte[10] { 173, 157, 145, 140, 155, 178, 159, 156, 155, 146 }, 254), new Vector2(922f, RowCy), new Vector2(400f, 72f), _0x20ea0d2f, _0x55236a9c._0xdd784b47(new byte[7] { 100, 116, 120, 101, 114, 23, 7 }, 55), _0x531552b7.SizeBody, _0x531552b7.SizeBodyMin, 48f, _0x2ac8856b.Cream, TextAlignmentOptions.Right);
        this._0xb9890891 = _0x29ecbd6a.Picture(_0xd06d5c2f, _0x55236a9c._0xdd784b47(new byte[9] { 197, 238, 231, 244, 225, 227, 201, 244, 228 }, 134), new Vector2(621f, RowCy), _0x531552b7.Square(104f), _0x20ea0d2f.Spark, _0x2ac8856b.Azure);
        this._0xc3d03dbf = _0x29ecbd6a.Bar(_0xd06d5c2f, _0x55236a9c._0xdd784b47(new byte[9] { 22, 50, 35, 63, 50, 37, 21, 54, 37 }, 87), new Vector2(_0x531552b7.PanelCx, BarCy), new Vector2(BarWidth, 54f), _0x20ea0d2f.Plate, _0x2ac8856b.Deep, _0x2ac8856b.Azure, BarInset);
        this._0x122a2905 = _0x29ecbd6a.Label(_0xd06d5c2f, _0x55236a9c._0xdd784b47(new byte[11] { 15, 43, 58, 38, 43, 60, 2, 47, 44, 43, 34 }, 78), new Vector2(_0x531552b7.PanelCx, BarCy), new Vector2(300f, 48f), _0x20ea0d2f, _0x55236a9c._0xdd784b47(new byte[4] { 224, 225, 225, 244 }, 209), _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 40f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
        this._0x63e81bc6 = _0x29ecbd6a.Node(_0xd06d5c2f, _0x55236a9c._0xdd784b47(new byte[9] { 58, 17, 24, 16, 23, 41, 16, 21, 21 }, 121), new Vector2(_0x531552b7.PanelCx, PillCy), new Vector2(320f, 76f));
        this._0x29a5ebb0 = _0x29ecbd6a.Scrim(this._0x63e81bc6, _0x55236a9c._0xdd784b47(new byte[10] { 143, 164, 173, 165, 162, 156, 160, 173, 184, 169 }, 204), _0x20ea0d2f.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Violet, 0.42f), false);
        this._0x957834d6 = _0x29ecbd6a.Label(this._0x63e81bc6, _0x55236a9c._0xdd784b47(new byte[10] { 152, 179, 186, 178, 181, 151, 186, 185, 190, 183 }, 219), new Vector2(160f, 38f), new Vector2(300f, 60f), _0x20ea0d2f, _0x55236a9c._0xdd784b47(new byte[10] { 234, 225, 232, 224, 231, 137, 209, 155, 135, 153 }, 169), _0x531552b7.SizeStrip, _0x531552b7.SizeStripMin, 44f, _0x2ac8856b.Lilac, TextAlignmentOptions.Center);
        this._0x63e81bc6.gameObject.SetActive(false);
    }

    private Image _0x29a5ebb0;
    public void _0x4983aa07(int _0xb4e06691)
    {
        _0x6bdb9d59.SetText(this._0xb9e261d5, _0x55236a9c._0xdd784b47(new byte[6] { 150, 134, 138, 151, 128, 229 }, 197) + _0xb4e06691.ToString());
    }

    public void _0xf681b087(float _0x9a569404, float _0x01afe652)
    {
        float _0x6fedf6da = _0x01afe652 <= 0f ? 0f : Mathf.Clamp01(_0x9a569404 / _0x01afe652);
        _0x29ecbd6a.SetBar(this._0xc3d03dbf, BarWidth - (BarInset * 2f), _0x6fedf6da);
        _0x6bdb9d59.SetText(this._0x122a2905, Mathf.RoundToInt(_0x6fedf6da * 100f).ToString() + _0x55236a9c._0xdd784b47(new byte[1] { 32 }, 5));
        if (this._0xc3d03dbf != null)
        {
            this._0xc3d03dbf.color = _0x6fedf6da < 0.25f ? _0x2ac8856b.Gold : _0x2ac8856b.Azure;
        }
    }

    private const float CardCy = 2140f;
    private Image _0xc3d03dbf;
    private RectTransform _0x63e81bc6;
    /// <summary>The pill is drawn only while the chain is worth showing - never an "x1.0" stub.</summary>
    public void _0xd3ad64d3(int _0xaf45e32e, float _0x6536f8dd)
    {
        bool _0x36dbc5ec = _0xaf45e32e >= 2;
        if (this._0x63e81bc6 != null)
        {
            this._0x63e81bc6.gameObject.SetActive(_0x36dbc5ec);
        }

        if (!_0x36dbc5ec)
        {
            return;
        }

        _0x6bdb9d59.SetText(this._0x957834d6, _0x55236a9c._0xdd784b47(new byte[7] { 196, 207, 198, 206, 201, 167, 255 }, 135) + _0x6536f8dd.ToString(_0x55236a9c._0xdd784b47(new byte[3] { 43, 53, 43 }, 27)));
        if (this._0x29a5ebb0 != null)
        {
            this._0x29a5ebb0.rectTransform.DOPunchScale(new Vector3(0.1f, 0.1f, 0f), 0.22f, 6, 0.6f).SetLink(this._0x29a5ebb0.gameObject);
        }
    }

    private TextMeshProUGUI _0x957834d6;
}

internal static class _0x55236a9c
{
    internal static string _0xdd784b47(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}