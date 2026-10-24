using UnityEngine;

/// <summary>
/// The one scene object of 1_MenuScene. It brands the splash and builds the Sky Map inside
/// the template's own panel bodies, both reached by INDEX through the controller's public
/// list - never by name.
///
/// SplashPanel.Content is {fileID: 0} on this template family, so the splash brand goes
/// into Panel.Content of the SPLASH panel and is pushed to the front of the child list so
/// the template's loading bar stays on top of it.
/// </summary>
public sealed class _0xccd3b0ce : MonoBehaviour
{
    [SerializeField]
    private _0xf6a1b425[] _courses;
    private void Start()
    {
        _0x84e527ab _0x038ef1fa = _0x84e527ab.Instance;
        if (_0x038ef1fa == null || _0x038ef1fa.Panels == null)
        {
            return;
        }

        _0x1d944efa.Silence();
        this._0x6d0ed430(_0x038ef1fa);
        this._0x38eb3338(_0x038ef1fa);
    }

    private void _0x6d0ed430(_0x84e527ab _0xfa6241fb)
    {
        if (_0x014c750c._0x50016d8c.SPLASH >= _0xfa6241fb.Panels.Count)
        {
            return;
        }

        _0xabf57bd7 _0xb81b6546 = _0xfa6241fb.Panels[_0x014c750c._0x50016d8c.SPLASH];
        if (_0xb81b6546 == null || _0xb81b6546.Content == null)
        {
            return;
        }

        RectTransform _0xddacf16b = _0x29ecbd6a.Layer(_0xb81b6546.Content.GetComponent<RectTransform>(), _0xcc52eb53._0xd9b27fba(new byte[15] { 183, 148, 136, 133, 151, 140, 166, 150, 133, 138, 128, 182, 139, 139, 144 }, 228));
        _0xddacf16b.SetAsFirstSibling();
        _0xde885c5e _0x02ffe321 = _0xddacf16b.gameObject.AddComponent<_0xde885c5e>();
        _0x02ffe321._0xc874029a(_0xddacf16b, this._art);
    }

    [SerializeField]
    private _0xadc65cb2 _art;
    private void _0x38eb3338(_0x84e527ab _0xd7b09dea)
    {
        if (_0x014c750c._0x50016d8c.DEFAULT >= _0xd7b09dea.Panels.Count)
        {
            return;
        }

        _0xabf57bd7 _0x338a41a7 = _0xd7b09dea.Panels[_0x014c750c._0x50016d8c.DEFAULT];
        if (_0x338a41a7 == null || _0x338a41a7.Content == null)
        {
            return;
        }

        _0x16a559e2 _0xe5bcca82 = new _0x16a559e2();
        RectTransform _0xfa2713c5 = _0x29ecbd6a.Layer(_0x338a41a7.Content.GetComponent<RectTransform>(), _0xcc52eb53._0xd9b27fba(new byte[11] { 95, 103, 117, 65, 109, 124, 95, 100, 105, 96, 96 }, 12));
        _0xdd53427b _0x5b820fbc = _0xfa2713c5.gameObject.AddComponent<_0xdd53427b>();
        _0x5b820fbc._0x8f78216d(_0xfa2713c5, this._art, _0xe5bcca82, this._courses);
        _0x5b820fbc._0x98f33894(_0xe5bcca82._0xb36b7342());
    }
}

internal static class _0xcc52eb53
{
    internal static string _0xd9b27fba(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}