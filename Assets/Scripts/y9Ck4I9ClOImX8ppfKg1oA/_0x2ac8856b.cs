using UnityEngine;

/// <summary>
/// The one palette of the sky course. Every entry is a literal so that no static
/// initialiser depends on another one: string encryption turns a const into a runtime
/// field and may reorder the declarations, which would kill the whole type (C.52).
/// Text is only ever tinted with the LIGHT entries - the shared font outline is Ink,
/// and a dark face on a dark outline reads as a blot (C.14).
/// </summary>
public static class _0x2ac8856b
{
    /// <summary>Surface colour of a ring / charge of the given element.</summary>
    public static Color OfRing(_0x5afdf70c _0x94b7ac04)
    {
        if (_0x94b7ac04 == _0x5afdf70c.Gold)
        {
            return Gold;
        }

        if (_0x94b7ac04 == _0x5afdf70c.Violet)
        {
            return Violet;
        }

        return Azure;
    }

    public static readonly Color Surface = new Color(0.063f, 0.200f, 0.310f, 1f);
    public static readonly Color Muted = new Color(0.663f, 0.769f, 0.831f, 1f);
    public static readonly Color Cream = new Color(0.945f, 0.980f, 0.933f, 1f);
    public static readonly Color Azure = new Color(0.086f, 0.541f, 0.678f, 1f);
    public static readonly Color Gold = new Color(0.976f, 0.780f, 0.310f, 1f);
    public static readonly Color Night = new Color(0.031f, 0.106f, 0.200f, 1f);
    public static readonly Color Ink = new Color(0.016f, 0.071f, 0.133f, 1f);
    public static readonly Color Lilac = new Color(0.780f, 0.643f, 0.961f, 1f);
    public static readonly Color Deep = new Color(0.047f, 0.153f, 0.259f, 1f);
    public static readonly Color Violet = new Color(0.608f, 0.365f, 0.898f, 1f);
    public static readonly Color Sky = new Color(0.435f, 0.827f, 0.910f, 1f);
    /// <summary>Readable TEXT colour for the given element (never a surface colour).</summary>
    public static Color TextOfRing(_0x5afdf70c _0xb3c40e9c)
    {
        if (_0xb3c40e9c == _0x5afdf70c.Gold)
        {
            return Gold;
        }

        if (_0xb3c40e9c == _0x5afdf70c.Violet)
        {
            return Lilac;
        }

        return Sky;
    }

    public static Color Faded(Color _0x91ac407c, float _0x4e048bdd)
    {
        return new Color(_0x91ac407c.r, _0x91ac407c.g, _0x91ac407c.b, _0x4e048bdd);
    }
}