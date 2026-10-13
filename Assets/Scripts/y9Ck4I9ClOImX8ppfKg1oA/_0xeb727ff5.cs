using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One tail trail in the vault: a ribbon swatch, its name, and either the selected mark or
/// the score it unlocks at. A locked card always carries its badge text - never a blank tile.
/// </summary>
public sealed class _0xeb727ff5 : MonoBehaviour
{
    private Button _0x0df53afc;
    private Image _0xc8bc49c7;
    private int _0x82d50e80;
    public void _0x2d224397(bool _0x4f8844cb)
    {
        if (this._0xc8bc49c7 != null)
        {
            this._0xc8bc49c7.color = _0x4f8844cb ? _0x2ac8856b.Gold : _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.5f);
        }

        if (this._0x97d57194 != null)
        {
            this._0x97d57194.color = _0x2ac8856b.Faded(this._0x04c111d9 ? _0x2ac8856b.Deep : _0x2ac8856b.Night, _0x4f8844cb ? 1f : 0.88f);
        }

        if (this._0x83bc7c49 != null)
        {
            this._0x83bc7c49.color = this._0x04c111d9 ? (_0x4f8844cb ? _0x2ac8856b.Gold : _0x2ac8856b.Sky) : _0x2ac8856b.Muted;
        }
    }

    /// <summary>The visible confirmation of a tap (C.7), alongside the preview retint.</summary>
    public void _0x0bbc9e99()
    {
        if (this._0x80f23f48 != null)
        {
            this._0x80f23f48.DOPunchScale(new Vector3(0.06f, 0.06f, 0f), 0.22f, 7, 0.7f).SetLink(this._0x80f23f48.gameObject);
        }
    }

    private bool _0x04c111d9;
    private RectTransform _0x80f23f48;
    public int _0x06380261
    {
        get
        {
            return this._0x82d50e80;
        }
    }

    private void OnDestroy()
    {
        DOTween.Kill(this._0x80f23f48);
    }

    private TextMeshProUGUI _0x83bc7c49;
    private Image _0x97d57194;
    public Button _0xdc1b0efc
    {
        get
        {
            return this._0x0df53afc;
        }
    }

    /// <summary>Builds into its own rect, so destroying it removes the whole card.</summary>
    public void _0x5968f5e0(RectTransform _0x4a1db603, _0xadc65cb2 _0xb82235cd, Vector2 _0x7a6e7b17, int _0x36d5159c, string _0xba546421, Color _0x4d0876c9, bool _0x62af9933, int _0x244d15b0)
    {
        this._0x82d50e80 = _0x36d5159c;
        this._0x04c111d9 = _0x62af9933;
        this._0x80f23f48 = _0x4a1db603;
        this._0xc8bc49c7 = _0x29ecbd6a.Scrim(this._0x80f23f48, _0xf381e27b._0x834dc8aa(new byte[8] { 125, 91, 72, 64, 69, 123, 64, 68 }, 41), _0xb82235cd.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.5f), false);
        this._0x97d57194 = _0x29ecbd6a.Inset(this._0x80f23f48, _0xf381e27b._0x834dc8aa(new byte[9] { 219, 253, 238, 230, 227, 205, 224, 235, 246 }, 143), 5f, _0xb82235cd.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Deep, 0.94f), 1.4f);
        float _0x8013a21c = _0x7a6e7b17.x * 0.5f;
        this._0x0c8c3e8a = _0x29ecbd6a.Plate(this._0x80f23f48, _0xf381e27b._0x834dc8aa(new byte[11] { 39, 1, 18, 26, 31, 32, 4, 18, 7, 16, 27 }, 115), new Vector2(_0x8013a21c, _0x7a6e7b17.y - 74f), new Vector2(_0x7a6e7b17.x - 84f, 52f), _0xb82235cd.Plate, _0x62af9933 ? _0x4d0876c9 : _0x2ac8856b.Faded(_0x4d0876c9, 0.3f), 0.7f);
        _0x29ecbd6a.Label(this._0x80f23f48, _0xf381e27b._0x834dc8aa(new byte[9] { 0, 38, 53, 61, 56, 26, 53, 57, 49 }, 84), new Vector2(_0x8013a21c, _0x7a6e7b17.y - 150f), new Vector2(_0x7a6e7b17.x - 30f, 60f), _0xb82235cd, _0xba546421, _0x531552b7.SizeBody, _0x531552b7.SizeBodyMin, 48f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
        this._0x83bc7c49 = _0x29ecbd6a.Label(this._0x80f23f48, _0xf381e27b._0x834dc8aa(new byte[10] { 158, 184, 171, 163, 166, 136, 171, 174, 173, 175 }, 202), new Vector2(_0x8013a21c, 52f), new Vector2(_0x7a6e7b17.x - 30f, 52f), _0xb82235cd, _0x62af9933 ? _0xf381e27b._0x834dc8aa(new byte[5] { 50, 37, 33, 36, 57 }, 96) : _0xf381e27b._0x834dc8aa(new byte[6] { 196, 211, 215, 213, 222, 182 }, 150) + _0x244d15b0.ToString(), _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 40f, _0x62af9933 ? _0x2ac8856b.Sky : _0x2ac8856b.Muted, TextAlignmentOptions.Center);
        this._0x0df53afc = _0x29ecbd6a.Tap(this._0x97d57194);
        this._0x2d224397(false);
    }

    private Image _0x0c8c3e8a;
}

internal static class _0xf381e27b
{
    internal static string _0x834dc8aa(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}