using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One card of the course rail: number, gate count, best score, lock state. Everything is
/// built INSIDE the card's own rect, so selecting it scales the whole card and not just
/// its backing plate. A locked card still carries a filled badge - never a blank tile.
/// </summary>
public sealed class _0x6ea8d464 : MonoBehaviour
{
    private int _0xa84eb1d4;
    private bool _0xb3107dd0;
    private TextMeshProUGUI _0x1b24ce4b;
    private Image _0x22fdf7d0;
    public Button _0x560e5131
    {
        get
        {
            return this._0x0b8d6eb6;
        }
    }

    public void _0x191d8e16(bool _0x05675538)
    {
        if (this._0x22fdf7d0 != null)
        {
            this._0x22fdf7d0.color = _0x05675538 ? _0x2ac8856b.Gold : _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.5f);
        }

        if (this._0x592d514f != null)
        {
            this._0x592d514f.color = this._0xb3107dd0 ? _0x2ac8856b.Faded(_0x2ac8856b.Deep, _0x05675538 ? 1f : 0.88f) : _0x2ac8856b.Faded(_0x2ac8856b.Night, 0.9f);
        }

        if (this._0x99a1cfbe != null)
        {
            this._0x99a1cfbe.color = this._0xb3107dd0 ? _0x2ac8856b.Cream : _0x2ac8856b.Muted;
        }

        if (this._0x1b24ce4b != null)
        {
            this._0x1b24ce4b.color = this._0xb3107dd0 ? _0x2ac8856b.Sky : _0x2ac8856b.Muted;
        }

        if (this._0x20910851 != null)
        {
            this._0x20910851.DOScale(_0x05675538 ? 1.06f : 1f, 0.18f).SetEase(Ease.OutQuad).SetLink(this._0x20910851.gameObject);
        }
    }

    /// <summary>
    /// The card builds INTO its own rect - the one this component sits on - so destroying
    /// the component's GameObject takes the whole card with it. A card whose visuals lived
    /// on the parent would survive a rebuild and the rail would double up.
    /// </summary>
    public void _0x15170e9f(RectTransform _0xf721c5e9, _0xadc65cb2 _0xe97c37ac, Vector2 _0x5d669fa0, int _0x23371c28, int _0x4d97598b, int _0xab4d64b3, bool _0x4fcb1c09)
    {
        this._0xa84eb1d4 = _0x23371c28;
        this._0xb3107dd0 = _0x4fcb1c09;
        this._0x20910851 = _0xf721c5e9;
        this._0x22fdf7d0 = _0x29ecbd6a.Scrim(this._0x20910851, _0x7a4d00d0._0x86af6fd9(new byte[9] { 185, 149, 143, 136, 137, 159, 168, 147, 151 }, 250), _0xe97c37ac.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.5f), false);
        this._0x592d514f = _0x29ecbd6a.Inset(this._0x20910851, _0x7a4d00d0._0x86af6fd9(new byte[10] { 90, 118, 108, 107, 106, 124, 91, 118, 125, 96 }, 25), 5f, _0xe97c37ac.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Deep, 0.94f), 1.4f);
        float _0x7c93bf1b = _0x5d669fa0.x * 0.5f;
        _0x29ecbd6a.Label(this._0x20910851, _0x7a4d00d0._0x86af6fd9(new byte[8] { 32, 12, 22, 17, 16, 6, 45, 12 }, 99), new Vector2(_0x7c93bf1b, _0x5d669fa0.y - 62f), new Vector2(_0x5d669fa0.x - 24f, 76f), _0xe97c37ac, _0x7a4d00d0._0x86af6fd9(new byte[1] { 38 }, 22) + (_0x23371c28 + 1).ToString(), _0x531552b7.SizeSection, _0x531552b7.SizeSectionMin, 62f, _0x2ac8856b.Gold, TextAlignmentOptions.Center);
        _0x29ecbd6a.Label(this._0x20910851, _0x7a4d00d0._0x86af6fd9(new byte[11] { 10, 38, 60, 59, 58, 44, 14, 40, 61, 44, 58 }, 73), new Vector2(_0x7c93bf1b, _0x5d669fa0.y - 136f), new Vector2(_0x5d669fa0.x - 24f, 52f), _0xe97c37ac, _0x4d97598b.ToString() + _0x7a4d00d0._0x86af6fd9(new byte[6] { 90, 61, 59, 46, 63, 41 }, 122), _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 40f, _0x2ac8856b.Sky, TextAlignmentOptions.Center);
        this._0x99a1cfbe = _0x29ecbd6a.Label(this._0x20910851, _0x7a4d00d0._0x86af6fd9(new byte[10] { 231, 203, 209, 214, 215, 193, 230, 193, 215, 208 }, 164), new Vector2(_0x7c93bf1b, _0x5d669fa0.y - 204f), new Vector2(_0x5d669fa0.x - 24f, 56f), _0xe97c37ac, _0xab4d64b3 > 0 ? _0xab4d64b3.ToString() : _0x7a4d00d0._0x86af6fd9(new byte[1] { 232 }, 197), _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 44f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
        this._0x1b24ce4b = _0x29ecbd6a.Label(this._0x20910851, _0x7a4d00d0._0x86af6fd9(new byte[11] { 186, 150, 140, 139, 138, 156, 170, 141, 152, 141, 156 }, 249), new Vector2(_0x7c93bf1b, 44f), new Vector2(_0x5d669fa0.x - 18f, 52f), _0xe97c37ac, _0x4fcb1c09 ? _0x7a4d00d0._0x86af6fd9(new byte[4] { 247, 232, 253, 246 }, 184) : _0x7a4d00d0._0x86af6fd9(new byte[7] { 77, 66, 75, 79, 92, 46, 62 }, 14) + _0x23371c28.ToString(), _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 38f, _0x2ac8856b.Sky, TextAlignmentOptions.Center);
        this._0x0b8d6eb6 = _0x29ecbd6a.Tap(this._0x592d514f);
        this._0x191d8e16(false);
    }

    private Image _0x592d514f;
    private TextMeshProUGUI _0x99a1cfbe;
    private Button _0x0b8d6eb6;
    public int _0x68cdee70
    {
        get
        {
            return this._0xa84eb1d4;
        }
    }

    private RectTransform _0x20910851;
    private void OnDestroy()
    {
        DOTween.Kill(this._0x20910851);
    }
}

internal static class _0x7a4d00d0
{
    internal static string _0x86af6fd9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}