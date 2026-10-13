using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Builds the game screen inside the template's own DefaultPanel body: the sky layers, the
/// play field, the dragon, the HUD, the two navigation buttons and the permanent control
/// hint. Draw order is build order, so the field goes down first and the HUD last.
///
/// Rule H, option two: the template's TopPanel is not used by this game at all - it carries
/// no content of ours and no reference from any of our components, and it is switched off
/// in the scene, so the screen has ONE set of buttons, not two in different styles.
/// </summary>
public sealed class _0x10aa417e : MonoBehaviour
{
    public _0xde649953 _0x8648fac9
    {
        get
        {
            return this._0x64579883;
        }
    }

    public void _0x35989b07(float _0xdcac92e2)
    {
        if (this._0x64579883 != null)
        {
            this._0x64579883._0x36394fdd(_0xdcac92e2);
        }
    }

    public Button _0xbefc681c
    {
        get
        {
            return this._0x259d0cfe;
        }
    }

    private Camera _0x5a799fb1;
    public RectTransform _0xc5e7df78
    {
        get
        {
            return this._0x2b884ab5;
        }
    }

    private _0xde649953 _0x64579883;
    /// <summary>
    /// Gates spawn here. It is created BEFORE the dragon, so every gate drawn during the
    /// run stays underneath it however late it appears - in uGUI the only draw order is
    /// hierarchy order, and a gate instantiated into the field itself would land after
    /// the dragon and cover it (C.13).
    /// </summary>
    public RectTransform _0x8b089aad
    {
        get
        {
            return this._0x41b91fda;
        }
    }

    private void OnDestroy()
    {
        DOTween.Kill(this._0x7fb59c9f);
    }

    public void _0x6c9b525c(float _0xe7cb9d35)
    {
        if (this._0x8fa1dd40 != null)
        {
            this._0x8fa1dd40._0x6c6449b3(_0xe7cb9d35);
        }

        if (this._0x8b3f7db7 != null)
        {
            this._0x8b3f7db7._0x6c6449b3(_0xe7cb9d35);
        }
    }

    private _0xea91f29d _0xba41c2bf;
    public void _0x6928b86a()
    {
        if (this._0x7fb59c9f == null)
        {
            return;
        }

        this._0x7fb59c9f.DOFade(0.45f, 0.12f).SetLoops(2, LoopType.Yoyo).SetLink(this._0x7fb59c9f.gameObject);
    }

    private Button _0x2ff6eebd;
    public Button _0x09a5504c
    {
        get
        {
            return this._0x2ff6eebd;
        }
    }

    private const float NavCy = 2400f;
    public _0xea91f29d _0x1db9e5c0
    {
        get
        {
            return this._0xba41c2bf;
        }
    }

    private Image _0xd400cdb1;
    private Image _0x185c7d51;
    private _0x74f82676 _0x8b3f7db7;
    private _0x74f82676 _0x8fa1dd40;
    private Image _0x7fb59c9f;
    private RectTransform _0x41b91fda;
    private Button _0x259d0cfe;
    public _0x8c355c33 _0x78a70968
    {
        get
        {
            return this._0x7706f97f;
        }
    }

    public void _0xd531bf33(bool _0xa82927f8, float _0x54c24d94, float _0x8cd469b0, float _0x91c6c20d)
    {
        if (this._0xc090775d == null)
        {
            return;
        }

        if (!_0xa82927f8)
        {
            this._0xc090775d.gameObject.SetActive(false);
            return;
        }

        float height = Mathf.Max(_0x91c6c20d - _0x531552b7.DragonY, 10f);
        this._0xc090775d.gameObject.SetActive(true);
        RectTransform _0x489aacc9 = this._0xc090775d.rectTransform;
        _0x489aacc9.sizeDelta = new Vector2(8f, height);
        _0x489aacc9.anchoredPosition = new Vector2(Mathf.Lerp(_0x531552b7.PanelCx + _0x54c24d94, _0x531552b7.PanelCx + _0x8cd469b0, 0.5f), _0x531552b7.DragonY + (height * 0.5f));
    }

    public void _0xafda021d(RectTransform _0x13c34272, _0xadc65cb2 _0xa6da4212, Image _0x7b3e3441, Color _0x4eea26c1, bool _0x679c0399, int _0x3298e732)
    {
        Canvas _0x76ef8e47 = _0x13c34272.GetComponentInParent<Canvas>();
        if (_0x76ef8e47 != null)
        {
            this._0x5a799fb1 = _0x76ef8e47.rootCanvas.worldCamera;
        }

        this._0x2b884ab5 = _0x29ecbd6a.Layer(_0x13c34272, _0x55f719d8._0xac510045(new byte[5] { 101, 74, 70, 79, 71 }, 35));
        this._0x8fa1dd40 = this._0x2b884ab5.gameObject.AddComponent<_0x74f82676>();
        this._0x8fa1dd40._0x9a36b090(this._0x2b884ab5, _0xa6da4212, _0x7b3e3441, _0x3298e732 ^ 7919, 34, 0.22f, 5f, 13f, _0x2ac8856b.Cream);
        this._0x8b3f7db7 = this._0x2b884ab5.gameObject.AddComponent<_0x74f82676>();
        this._0x8b3f7db7._0x9a36b090(this._0x2b884ab5, _0xa6da4212, _0x7b3e3441, _0x3298e732 ^ 104729, 16, 0.55f, 22f, 64f, _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.6f));
        this._0xc090775d = _0x29ecbd6a.Plate(this._0x2b884ab5, _0x55f719d8._0xac510045(new byte[9] { 183, 133, 153, 148, 149, 178, 149, 145, 157 }, 240), new Vector2(_0x531552b7.PanelCx, _0x531552b7.DragonY), new Vector2(8f, 10f), _0xa6da4212.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Cream, 0.5f), 0.6f);
        this._0xc090775d.gameObject.SetActive(false);
        this._0x41b91fda = _0x29ecbd6a.Layer(this._0x2b884ab5, _0x55f719d8._0xac510045(new byte[5] { 41, 15, 26, 11, 29 }, 110));
        RectTransform _0x8580f79d = _0x29ecbd6a.Layer(this._0x2b884ab5, _0x55f719d8._0xac510045(new byte[5] { 252, 218, 201, 193, 196 }, 168));
        this._0xba41c2bf = _0x8580f79d.gameObject.AddComponent<_0xea91f29d>();
        this._0xba41c2bf._0xb7641a99(_0x8580f79d, _0xa6da4212, _0x7b3e3441, _0x4eea26c1);
        this._0x7c117ddb = _0x29ecbd6a.Node(this._0x2b884ab5, _0x55f719d8._0xac510045(new byte[6] { 159, 169, 186, 188, 180, 181 }, 219), new Vector2(_0x531552b7.PanelCx, _0x531552b7.DragonY), _0x531552b7.Square(_0x531552b7.DragonH));
        this._0xd400cdb1 = _0x29ecbd6a.Picture(this._0x7c117ddb, _0x55f719d8._0xac510045(new byte[10] { 99, 85, 70, 64, 72, 73, 96, 75, 72, 80 }, 39), new Vector2(_0x531552b7.DragonH * 0.5f, _0x531552b7.DragonH * 0.5f), _0x531552b7.Square(_0x531552b7.DragonH * 1.5f), _0xa6da4212.Spark, _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.55f));
        this._0x185c7d51 = _0x29ecbd6a.Picture(this._0x7c117ddb, _0x55f719d8._0xac510045(new byte[10] { 66, 116, 103, 97, 105, 104, 68, 105, 98, 127 }, 6), new Vector2(_0x531552b7.DragonH * 0.5f, _0x531552b7.DragonH * 0.5f), _0x531552b7.Square(_0x531552b7.DragonH), _0xa6da4212.Dragon, Color.white);
        this._0x64579883 = this._0x7c117ddb.gameObject.AddComponent<_0xde649953>();
        this._0x64579883._0x0ea00d8f(this._0x2b884ab5, this._0x7c117ddb, this._0x185c7d51, this._0xd400cdb1, this._0xba41c2bf, this._0x5a799fb1, _0x679c0399);
        this._0x7fb59c9f = _0x29ecbd6a.Scrim(_0x13c34272, _0x55f719d8._0xac510045(new byte[8] { 216, 249, 228, 214, 252, 241, 227, 248 }, 144), _0xa6da4212.Plate, new Color(0.84f, 0.18f, 0.24f, 0f), false);
        this._0x7706f97f = _0x13c34272.gameObject.AddComponent<_0x8c355c33>();
        this._0x7706f97f._0xdf1e055d(_0x13c34272, _0xa6da4212);
        this._0x259d0cfe = this._0x36d62fbe(_0x13c34272, _0xa6da4212, _0x55f719d8._0xac510045(new byte[10] { 129, 162, 160, 168, 129, 182, 183, 183, 172, 173 }, 195), new Vector2(120f, NavCy), _0xa6da4212.IconBack);
        this._0x2ff6eebd = this._0x36d62fbe(_0x13c34272, _0xa6da4212, _0x55f719d8._0xac510045(new byte[11] { 68, 117, 97, 103, 113, 86, 97, 96, 96, 123, 122 }, 20), new Vector2(1122f, NavCy), _0xa6da4212.IconPause);
        // C.6: the control scheme is not just "tap a button", so the gesture AND its result
        // are named on screen for the whole run - and therefore in the review frame.
        _0x29ecbd6a.Card(_0x13c34272, _0x55f719d8._0xac510045(new byte[8] { 10, 43, 44, 54, 1, 35, 48, 38 }, 66), new Vector2(_0x531552b7.PanelCx, HintCy), new Vector2(1002f, 96f), _0xa6da4212.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Surface, 0.72f), _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.45f), 1.5f, 3f);
        _0x29ecbd6a.Label(_0x13c34272, _0x55f719d8._0xac510045(new byte[9] { 83, 114, 117, 111, 87, 122, 121, 126, 119 }, 27), new Vector2(_0x531552b7.PanelCx, HintCy), new Vector2(960f, 70f), _0xa6da4212, _0x55f719d8._0xac510045(new byte[44] { 140, 139, 136, 128, 228, 139, 150, 228, 144, 133, 148, 228, 133, 228, 151, 141, 128, 129, 228, 144, 139, 228, 134, 133, 138, 143, 228, 233, 228, 137, 133, 144, 135, 140, 228, 157, 139, 145, 150, 228, 131, 136, 139, 147 }, 196), _0x531552b7.SizeHint, _0x531552b7.SizeHintMin, 42f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
    }

    private Image _0xc090775d;
    private _0x8c355c33 _0x7706f97f;
    private RectTransform _0x7c117ddb;
    private RectTransform _0x2b884ab5;
    private const float HintCy = 150f;
    private Button _0x36d62fbe(RectTransform _0xc44b46d7, _0xadc65cb2 _0x44c62722, string _0xcbd54246, Vector2 _0x25d02692, Sprite _0x49cd32cb)
    {
        Image _0x0a644c56 = _0x29ecbd6a.Plate(_0xc44b46d7, _0xcbd54246, _0x25d02692, _0x531552b7.Square(136f), _0x44c62722.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Deep, 0.92f), 0.9f);
        _0x29ecbd6a.Picture(_0xc44b46d7, _0xcbd54246, _0x25d02692, _0x531552b7.Square(72f), _0x49cd32cb, _0x2ac8856b.Gold);
        return _0x29ecbd6a.Tap(_0x0a644c56);
    }
}

internal static class _0x55f719d8
{
    internal static string _0xac510045(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}