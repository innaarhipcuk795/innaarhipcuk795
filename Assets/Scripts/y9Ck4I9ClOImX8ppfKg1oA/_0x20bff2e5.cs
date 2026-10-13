using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The one scene object of 2_GameScene. It builds the game inside the template's own
/// DefaultPanel body, reached by INDEX through the controller's public list, and wires the
/// director to the pops. Everything it needs is a serialized reference, so nothing here
/// depends on a name obfuscation will rewrite.
/// </summary>
public sealed class _0x20bff2e5 : MonoBehaviour
{
    private _0xf6a1b425 _0x3b3a9124(int _0x8c396858)
    {
        if (this._courses != null && _0x8c396858 >= 0 && _0x8c396858 < this._courses.Length && this._courses[_0x8c396858] != null)
        {
            return this._courses[_0x8c396858];
        }

        return new _0xf6a1b425();
    }

    private void _0x2e569dbd()
    {
        _0x2bc80d8c.Instance._0x99ca33d7(true);
        _0x2bc80d8c.Instance._0xf6240625(_0x014c750c._0x99049008.SCENE_0);
    }

    [SerializeField]
    private _0xb5c60795 _shardPrefab;
    private _0x32a44ae3 _0x46883c07;
    [SerializeField]
    private _0x78f632c2 _ringPrefab;
    private void Start()
    {
        _0x84e527ab _0x9986b1be = _0x84e527ab.Instance;
        if (_0x9986b1be == null || _0x9986b1be.Panels == null || _0x014c750c._0x50016d8c.DEFAULT >= _0x9986b1be.Panels.Count)
        {
            return;
        }

        _0xabf57bd7 _0xcb347580 = _0x9986b1be.Panels[_0x014c750c._0x50016d8c.DEFAULT];
        if (_0xcb347580 == null || _0xcb347580.Content == null)
        {
            return;
        }

        _0x1d944efa.Silence();
        _0x16a559e2 _0xb4584690 = new _0x16a559e2();
        int _0xfd9a4931 = _0xb4584690._0x72cb91c4();
        _0xf6a1b425 _0xe406f0b3 = this._0x3b3a9124(_0xfd9a4931);
        Color _0xf37174f7 = _0x60f3352c[Mathf.Clamp(_0xb4584690._0x2d5857e0(), 0, _0x60f3352c.Length - 1)];
        RectTransform _0x14e46dbc = _0x29ecbd6a.Layer(_0xcb347580.Content.GetComponent<RectTransform>(), _0xc90573d8._0x070935d4(new byte[10] { 44, 6, 3, 13, 2, 30, 56, 5, 5, 30 }, 106));
        _0x10aa417e _0xa2162a2c = _0x14e46dbc.gameObject.AddComponent<_0x10aa417e>();
        _0xa2162a2c._0xafda021d(_0x14e46dbc, this._art, this._motePrefab, _0xf37174f7, _0xb4584690._0xb36b7342(), (_0xfd9a4931 * 7919) ^ 104729);
        _0x07ce4a95 _0x1b1edcb4 = _0x14e46dbc.gameObject.AddComponent<_0x07ce4a95>();
        this._0x46883c07 = _0x14e46dbc.gameObject.AddComponent<_0x32a44ae3>();
        this._0x46883c07._0x024b0d5f(_0xa2162a2c, this._art, this._ringPrefab, this._shardPrefab, _0x1b1edcb4, _0xb4584690, _0xe406f0b3, _0xfd9a4931);
        if (_0xa2162a2c._0xbefc681c != null)
        {
            _0xa2162a2c._0xbefc681c.onClick.AddListener(() => this._0x2e569dbd());
        }

        if (_0xa2162a2c._0x09a5504c != null)
        {
            _0xa2162a2c._0x09a5504c.onClick.AddListener(() => this._0xa496cc2d());
        }
    }

    private void _0xa496cc2d()
    {
        if (this._0x46883c07 != null)
        {
            this._0x46883c07._0xf2e6bbfb();
        }
    }

    [SerializeField]
    private Image _motePrefab;
    private static readonly Color[] _0x60f3352c =
    {
        new Color(0.976f, 0.482f, 0.263f, 1f),
        new Color(0.086f, 0.541f, 0.678f, 1f),
        new Color(0.608f, 0.365f, 0.898f, 1f),
        new Color(0.976f, 0.780f, 0.310f, 1f),
        new Color(0.435f, 0.827f, 0.910f, 1f),
        new Color(0.780f, 0.643f, 0.961f, 1f)
    };
    [SerializeField]
    private _0xadc65cb2 _art;
    [SerializeField]
    private _0xf6a1b425[] _courses;
}

internal static class _0xc90573d8
{
    internal static string _0x070935d4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}