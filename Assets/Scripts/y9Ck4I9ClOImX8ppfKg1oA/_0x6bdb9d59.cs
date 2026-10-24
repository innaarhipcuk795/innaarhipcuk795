using TMPro;
using UnityEngine;

/// <summary>
/// C.10: a label created from C# is in no scene file, so stage 5c3 never sees it and
/// guarantees nothing for it. Every runtime label gets its own material instance with an
/// outline that contrasts with its face, and the wrapping / autosize discipline that the
/// serialized labels get from the scene.
/// </summary>
public static class _0x6bdb9d59
{
    public const float OutlineWidth = 0.22f;
    public static void SetText(TMP_Text _0x7e87d3f7, string _0x5065ed2f)
    {
        if (_0x7e87d3f7 != null)
        {
            _0x7e87d3f7.text = _0x5065ed2f;
        }
    }

    public static void Tint(TMP_Text _0x26d24ff7, Color _0xb2f95435)
    {
        if (_0x26d24ff7 == null)
        {
            return;
        }

        _0x26d24ff7.color = _0xb2f95435;
        ApplyOutline(_0x26d24ff7);
    }

    /// <summary>
    /// Wrapping OFF, autosize ON, minimum at the readability floor. Line breaks are
    /// placed by hand with an explicit escape in the string, never by the engine.
    /// </summary>
    public static void ApplyFlow(TMP_Text _0x94b8bd1c, float _0x88bde946, float _0xeb0dcd1d)
    {
        if (_0x94b8bd1c == null)
        {
            return;
        }

        _0x94b8bd1c.textWrappingMode = TextWrappingModes.NoWrap;
        _0x94b8bd1c.overflowMode = TextOverflowModes.Overflow;
        _0x94b8bd1c.enableAutoSizing = true;
        _0x94b8bd1c.fontSizeMin = _0x88bde946;
        _0x94b8bd1c.fontSizeMax = _0xeb0dcd1d;
    }

    public static void ApplyOutline(TMP_Text _0xbf59da19)
    {
        if (_0xbf59da19 == null)
        {
            return;
        }

        Color _0xa25433c0 = _0xbf59da19.color;
        float _0x94b6ffc3 = (0.299f * _0xa25433c0.r) + (0.587f * _0xa25433c0.g) + (0.114f * _0xa25433c0.b);
        Color _0x3a8e1542 = _0x94b6ffc3 < 0.5f ? _0x2ac8856b.Cream : _0x2ac8856b.Ink;
        Material _0x65f2ab95 = _0xbf59da19.fontMaterial;
        if (_0x65f2ab95 == null)
        {
            return;
        }

        _0x65f2ab95.SetColor(ShaderUtilities.ID_OutlineColor, _0x3a8e1542);
        _0x65f2ab95.SetFloat(ShaderUtilities.ID_OutlineWidth, OutlineWidth);
    }
}