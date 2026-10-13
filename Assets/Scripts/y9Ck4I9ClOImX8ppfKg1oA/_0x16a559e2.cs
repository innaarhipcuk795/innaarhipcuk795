using UnityEngine;

/// <summary>
/// Local progress. Keys are LITERAL strings, never nameof: obfuscation rewrites a symbol
/// name and the saved data would be orphaned on the next build.
/// Instantiated and injected, never a singleton of its own.
/// </summary>
public sealed class _0x16a559e2
{
    private static readonly string KeyHaptics = _0x682bb773._0x24cdd553(new byte[10] { 235, 253, 161, 231, 238, 255, 251, 230, 236, 252 }, 143);
    public int _0x72cb91c4()
    {
        return Mathf.Clamp(PlayerPrefs.GetInt(KeyCourse, 0), 0, CourseCount - 1);
    }

    private static readonly string KeyBest = _0x682bb773._0x24cdd553(new byte[8] { 101, 115, 47, 99, 100, 114, 117, 47 }, 1);
    private static readonly string KeyAttempt = _0x682bb773._0x24cdd553(new byte[10] { 213, 195, 159, 208, 197, 197, 212, 220, 193, 197 }, 177);
    public void _0x4d3f8a4c(bool _0x9920ac3b)
    {
        PlayerPrefs.SetInt(KeyGuides, _0x9920ac3b ? 1 : 0);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// The attempt counter that seeds the next run. Persisted rather than taken from the
    /// clock, so a run is reproducible from the seed printed in the log, and two runs in a
    /// row are still visibly different courses (C.11).
    /// </summary>
    public int _0x95091cb1()
    {
        int _0x30e4bbbf = PlayerPrefs.GetInt(KeyAttempt, 0) + 1;
        PlayerPrefs.SetInt(KeyAttempt, _0x30e4bbbf);
        PlayerPrefs.Save();
        return _0x30e4bbbf;
    }

    public bool _0xb36b7342()
    {
        return PlayerPrefs.GetInt(KeyMotion, 0) == 1;
    }

    public bool _0x53f9335d()
    {
        return PlayerPrefs.GetInt(KeyGuides, 1) == 1;
    }

    private static readonly string KeyCourse = _0x682bb773._0x24cdd553(new byte[9] { 136, 158, 194, 143, 131, 153, 158, 159, 137 }, 236);
    public void _0x76effd92(bool _0xf34fe8e7)
    {
        PlayerPrefs.SetInt(KeyMotion, _0xf34fe8e7 ? 1 : 0);
        PlayerPrefs.Save();
    }

    public int _0xe1c096e1(int _0xae246d80)
    {
        int _0xabd594b2 = Mathf.Clamp(_0xae246d80, 0, TrailCount - 1);
        return _0x50163df3[_0xabd594b2];
    }

    public void _0x1b642f71(int _0x562612a0, int _0x551addb7)
    {
        if (_0x551addb7 > this._0xd5490c0f(_0x562612a0))
        {
            PlayerPrefs.SetInt(KeyBest + _0x562612a0.ToString(), _0x551addb7);
        }

        PlayerPrefs.Save();
    }

    public int _0xd5490c0f(int _0xc2d03616)
    {
        return PlayerPrefs.GetInt(KeyBest + _0xc2d03616.ToString(), 0);
    }

    private static readonly string KeyMotion = _0x682bb773._0x24cdd553(new byte[9] { 235, 253, 161, 226, 224, 251, 230, 224, 225 }, 143);
    /// <summary>Wipes every record and the shard purse, leaving the settings alone.</summary>
    public void _0x820ef773()
    {
        for (int _0x9eb153c3 = 0; _0x9eb153c3 < CourseCount; _0x9eb153c3++)
        {
            PlayerPrefs.SetInt(KeyBest + _0x9eb153c3.ToString(), 0);
        }

        PlayerPrefs.SetInt(KeyCourse, 0);
        PlayerPrefs.Save();
    }

    public bool _0x532fee19(int _0xf75d5609)
    {
        return this._0xdb787586() >= this._0xe1c096e1(_0xf75d5609);
    }

    public void _0xed1aa910(int _0x89bfb018)
    {
        PlayerPrefs.SetInt(KeyCourse, Mathf.Clamp(_0x89bfb018, 0, CourseCount - 1));
        PlayerPrefs.Save();
    }

    public const int TrailCount = 6;
    public const int CourseCount = 5;
    public bool _0x7c8bba6e()
    {
        return PlayerPrefs.GetInt(KeyHaptics, 1) == 1;
    }

    public int _0x2d5857e0()
    {
        return Mathf.Clamp(PlayerPrefs.GetInt(KeyTrail, 0), 0, TrailCount - 1);
    }

    public void _0x6fa7d0d1(int _0x65ee1398)
    {
        PlayerPrefs.SetInt(KeyTrail, Mathf.Clamp(_0x65ee1398, 0, TrailCount - 1));
        PlayerPrefs.Save();
    }

    private static readonly string KeyTrail = _0x682bb773._0x24cdd553(new byte[8] { 12, 26, 70, 28, 26, 9, 1, 4 }, 104);
    private static readonly string KeyGuides = _0x682bb773._0x24cdd553(new byte[9] { 91, 77, 17, 88, 74, 86, 91, 90, 76 }, 63);
    public int _0xdb787586()
    {
        int _0x80cad079 = 0;
        for (int _0x7cd34473 = 0; _0x7cd34473 < CourseCount; _0x7cd34473++)
        {
            int _0x1748f12e = this._0xd5490c0f(_0x7cd34473);
            if (_0x1748f12e > _0x80cad079)
            {
                _0x80cad079 = _0x1748f12e;
            }
        }

        return _0x80cad079;
    }

    private static readonly int[] _0x50163df3 =
    {
        0,
        1200,
        2600,
        4200,
        6000,
        8400
    };
    /// <summary>A course is open once the one before it has a logged flight.</summary>
    public bool _0x99f01839(int _0x858a0abd)
    {
        if (_0x858a0abd <= 0)
        {
            return true;
        }

        return this._0xd5490c0f(_0x858a0abd - 1) > 0;
    }

    public void _0xf8fed59e(bool _0xb95b434f)
    {
        PlayerPrefs.SetInt(KeyHaptics, _0xb95b434f ? 1 : 0);
        PlayerPrefs.Save();
    }
}

internal static class _0x682bb773
{
    internal static string _0x24cdd553(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}