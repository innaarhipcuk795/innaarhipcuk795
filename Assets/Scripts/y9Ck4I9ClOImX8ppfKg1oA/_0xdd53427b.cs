using DG.Tweening;
using TMPro;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The Sky Map and its two overlays, built inside the template's own DefaultPanel body.
///
/// The PLAY slot is the template's pre-wired button (a LoadSceneButton to scene 1): this
/// director draws the button's FACE over it with every graphic's raycastTarget off, so the
/// tap falls through to the real button and there is never a second, parallel Play.
/// </summary>
public sealed class _0xdd53427b : MonoBehaviour
{
    private RectTransform _0x8f9f5577;
    private _0x50225373 _0xb5a4ea61;
    /// <summary>
    /// Builds the five course cards. Called again after a reset, so each card must be a
    /// self-contained object the rebuild can destroy whole.
    /// </summary>
    private void _0x37b1c006()
    {
        float[] _0x58651c15 =
        {
            161f,
            391f,
            621f,
            851f,
            1081f
        };
        this._0x21327b36 = new _0x6ea8d464[_0x16a559e2.CourseCount];
        for (int _0x27d61d01 = 0; _0x27d61d01 < _0x16a559e2.CourseCount; _0x27d61d01++)
        {
            Vector2 _0xbb1b5baa = new Vector2(CardW, CardH);
            RectTransform _0x9b1f6a2c = _0x29ecbd6a.Node(this._0xacb83996, _0x25be1630._0x4de58997(new byte[10] { 101, 73, 83, 84, 85, 67, 101, 71, 84, 66 }, 38), new Vector2(_0x58651c15[_0x27d61d01], RailCy), _0xbb1b5baa);
            _0x6ea8d464 _0x5b1851f3 = _0x9b1f6a2c.gameObject.AddComponent<_0x6ea8d464>();
            _0x5b1851f3._0x15170e9f(_0x9b1f6a2c, this._0x76792631, _0xbb1b5baa, _0x27d61d01, this._0x38abc25f(_0x27d61d01), this._0x7adf85ff._0xd5490c0f(_0x27d61d01), this._0x7adf85ff._0x99f01839(_0x27d61d01));
            int _0xb28c7aaf = _0x27d61d01;
            _0x5b1851f3._0x560e5131.onClick.AddListener(() => this._0xfcf051ac(_0xb28c7aaf));
            this._0x21327b36[_0x27d61d01] = _0x5b1851f3;
        }
    }

    private const float CardH = 340f;
    private const float PlayW = 760f;
    private RectTransform _0x12ff7ce0;
    private const float PlayH = 168f;
    private RectTransform _0xacb83996;
    private void _0x37f2c787()
    {
        this._0xec32760f.gameObject.SetActive(false);
        this._0x12ff7ce0.gameObject.SetActive(false);
        this._0x7796f19b();
    }

    private void _0xb5a469ff(int _0xb5b12d3a)
    {
        if (!this._0x7adf85ff._0x532fee19(_0xb5b12d3a))
        {
            return;
        }

        this._0x7adf85ff._0x6fa7d0d1(_0xb5b12d3a);
        if (this._0x42dfa1dc[_0xb5b12d3a] != null)
        {
            this._0x42dfa1dc[_0xb5b12d3a]._0x0bbc9e99();
        }

        this._0x23cd0220();
        this._0x39c2b988();
    }

    private _0x50225373 _0x4b0a67f0;
    // -- Sky Map -------------------------------------------------------------------
    private void _0xf338ec18(RectTransform _0x55c0ed21)
    {
        _0x29ecbd6a.Picture(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[6] { 218, 242, 253, 243, 250, 242 }, 159), new Vector2(_0x531552b7.PanelCx, 2420f), _0x531552b7.Square(170f), this._0x76792631.Mark, Color.white);
        _0x29ecbd6a.Label(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[9] { 39, 10, 2, 13, 11, 28, 1, 30, 13 }, 104), new Vector2(_0x531552b7.PanelCx, 2270f), new Vector2(1002f, 70f), this._0x76792631, _0x25be1630._0x4de58997(new byte[33] { 197, 217, 195, 212, 208, 213, 177, 197, 217, 212, 177, 195, 216, 223, 214, 194, 177, 188, 177, 218, 212, 212, 193, 177, 197, 217, 212, 177, 210, 217, 208, 216, 223 }, 145), _0x531552b7.SizeBody, _0x531552b7.SizeBodyMin, 48f, _0x2ac8856b.Sky, TextAlignmentOptions.Center);
        _0x29ecbd6a.Card(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[9] { 1, 58, 51, 32, 54, 2, 59, 62, 62 }, 82), new Vector2(960f, 2560f), new Vector2(420f, 100f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Deep, 0.92f), _0x2ac8856b.Faded(_0x2ac8856b.Gold, 0.7f), 1.1f, 4f);
        _0x29ecbd6a.Picture(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[9] { 97, 90, 83, 64, 86, 123, 81, 93, 92 }, 50), new Vector2(820f, 2560f), _0x531552b7.Square(60f), this._0x76792631.Shard, _0x2ac8856b.Gold);
        this._0x958a244c = _0x29ecbd6a.Label(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[10] { 205, 246, 255, 236, 250, 210, 255, 252, 251, 242 }, 158), new Vector2(1000f, 2560f), new Vector2(240f, 60f), this._0x76792631, _0x25be1630._0x4de58997(new byte[1] { 187 }, 139), _0x531552b7.SizeBody, _0x531552b7.SizeBodyMin, 48f, _0x2ac8856b.Gold, TextAlignmentOptions.Left);
        this._0x8f9f5577 = _0x29ecbd6a.Node(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[7] { 196, 230, 241, 226, 253, 241, 227 }, 148), new Vector2(_0x531552b7.PanelCx, 2010f), _0x531552b7.Square(400f));
        this._0xb2b5b615 = _0x29ecbd6a.Picture(this._0x8f9f5577, _0x25be1630._0x4de58997(new byte[13] { 28, 62, 41, 58, 37, 41, 59, 30, 37, 46, 46, 35, 34 }, 76), new Vector2(200f, 140f), _0x531552b7.Square(290f), this._0x76792631.Spark, _0x2ac8856b.Azure);
        _0x29ecbd6a.Picture(this._0x8f9f5577, _0x25be1630._0x4de58997(new byte[13] { 37, 7, 16, 3, 28, 16, 2, 49, 7, 20, 18, 26, 27 }, 117), new Vector2(200f, 200f), _0x531552b7.Square(360f), this._0x76792631.Dragon, Color.white);
        this._0x37b1c006();
        this._0xd173f147 = _0x29ecbd6a.Label(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[11] { 63, 8, 14, 2, 31, 9, 62, 25, 31, 4, 29 }, 109), new Vector2(_0x531552b7.PanelCx, 1270f), new Vector2(1002f, 70f), this._0x76792631, _0x25be1630._0x4de58997(new byte[20] { 9, 8, 103, 1, 11, 14, 0, 15, 19, 103, 11, 8, 0, 0, 2, 3, 103, 30, 2, 19 }, 71), _0x531552b7.SizeStrip, _0x531552b7.SizeStripMin, 44f, _0x2ac8856b.Muted, TextAlignmentOptions.Center);
        // The face of the template's own Play button: every layer raycastTarget off, so
        // the tap reaches the button underneath.
        _0x29ecbd6a.Card(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[8] { 52, 8, 5, 29, 34, 5, 7, 1 }, 100), new Vector2(_0x531552b7.PanelCx, PlayCy), new Vector2(PlayW, PlayH), this._0x76792631.Plate, _0x2ac8856b.Azure, _0x2ac8856b.Gold, 1.35f, 5f);
        _0x29ecbd6a.Plate(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[8] { 25, 37, 40, 48, 14, 37, 38, 62 }, 73), new Vector2(_0x531552b7.PanelCx, PlayCy), new Vector2(PlayW - 44f, PlayH - 44f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Violet, 0.45f), 1.2f);
        _0x29ecbd6a.Label(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[9] { 218, 230, 235, 243, 198, 235, 232, 239, 230 }, 138), new Vector2(_0x531552b7.PanelCx, PlayCy), new Vector2(PlayW - 60f, 100f), this._0x76792631, _0x25be1630._0x4de58997(new byte[4] { 149, 137, 132, 156 }, 197), _0x531552b7.SizePlay, _0x531552b7.SizePlayMin, 80f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
        this._0xbbe97240(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[11] { 150, 161, 181, 172, 180, 130, 181, 180, 180, 175, 174 }, 192), new Vector2(420f, 640f), _0x25be1630._0x4de58997(new byte[11] { 218, 220, 207, 199, 194, 174, 216, 207, 219, 194, 218 }, 142), () => this._0x30758429());
        this._0xbbe97240(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[14] { 248, 206, 223, 223, 194, 197, 204, 216, 233, 222, 223, 223, 196, 197 }, 171), new Vector2(822f, 640f), _0x25be1630._0x4de58997(new byte[8] { 246, 224, 241, 241, 236, 235, 226, 246 }, 165), () => this._0x86fbe709());
        _0x29ecbd6a.Card(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[9] { 164, 131, 155, 184, 131, 175, 141, 158, 136 }, 236), new Vector2(_0x531552b7.PanelCx, 430f), new Vector2(1002f, 110f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Surface, 0.62f), _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.4f), 1.6f, 3f);
        _0x29ecbd6a.Label(_0x55c0ed21, _0x25be1630._0x4de58997(new byte[10] { 239, 200, 208, 243, 200, 235, 198, 197, 194, 203 }, 167), new Vector2(_0x531552b7.PanelCx, 430f), new Vector2(950f, 76f), this._0x76792631, _0x25be1630._0x4de58997(new byte[26] { 190, 185, 186, 178, 214, 185, 164, 214, 162, 183, 166, 214, 183, 214, 165, 191, 178, 179, 214, 162, 185, 214, 180, 183, 184, 189 }, 246), _0x531552b7.SizeHint, _0x531552b7.SizeHintMin, 42f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
    }

    private _0x50225373 _0xf4bdf4e1(RectTransform _0xf79d6b91, string _0x55d6827f, float _0x8a0ebaa1, bool _0xa3991786, UnityAction _0x6cda064c)
    {
        _0x29ecbd6a.Card(_0xf79d6b91, _0x25be1630._0x4de58997(new byte[11] { 188, 138, 155, 155, 134, 129, 136, 156, 189, 128, 152 }, 239), new Vector2(_0x531552b7.PanelCx, _0x8a0ebaa1), new Vector2(1000f, 130f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Surface, 0.7f), _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.35f), 1.6f, 2f);
        _0x29ecbd6a.Label(_0xf79d6b91, _0x25be1630._0x4de58997(new byte[16] { 154, 172, 189, 189, 160, 167, 174, 186, 155, 166, 190, 133, 168, 171, 172, 165 }, 201), new Vector2(400f, _0x8a0ebaa1), new Vector2(440f, 66f), this._0x76792631, _0x55d6827f, _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 44f, _0x2ac8856b.Cream, TextAlignmentOptions.Left);
        RectTransform _0x56862677 = _0x29ecbd6a.Node(_0xf79d6b91, _0x25be1630._0x4de58997(new byte[10] { 57, 2, 10, 10, 1, 8, 61, 4, 1, 1 }, 109), new Vector2(900f, _0x8a0ebaa1), new Vector2(220f, 88f));
        _0x50225373 _0x750ddaff = _0x56862677.gameObject.AddComponent<_0x50225373>();
        _0x750ddaff._0x72c62e82(_0x56862677, this._0x76792631, new Vector2(900f, _0x8a0ebaa1), _0xa3991786);
        _0x750ddaff._0xc1aaacdb.onClick.AddListener(() => _0x6cda064c());
        return _0x750ddaff;
    }

    private TextMeshProUGUI _0x958a244c;
    private void _0x9587a4ca(RectTransform _0xb58a075f)
    {
        float[] _0x255fa7d2 =
        {
            361f,
            881f
        };
        float[] _0x48eda152 =
        {
            1700f,
            1364f,
            1028f
        };
        this._0x42dfa1dc = new _0xeb727ff5[_0x16a559e2.TrailCount];
        for (int _0x90544239 = 0; _0x90544239 < _0x16a559e2.TrailCount; _0x90544239++)
        {
            Vector2 _0xdfbfcd71 = new Vector2(480f, 300f);
            RectTransform _0xc381897c = _0x29ecbd6a.Node(_0xb58a075f, _0x25be1630._0x4de58997(new byte[9] { 57, 31, 12, 4, 1, 46, 12, 31, 9 }, 109), new Vector2(_0x255fa7d2[_0x90544239 % 2], _0x48eda152[_0x90544239 / 2]), _0xdfbfcd71);
            _0xeb727ff5 _0x1fcb18a4 = _0xc381897c.gameObject.AddComponent<_0xeb727ff5>();
            _0x1fcb18a4._0x5968f5e0(_0xc381897c, this._0x76792631, _0xdfbfcd71, _0x90544239, _0xbbac0c2c[_0x90544239], _0xbd8997f5[_0x90544239], this._0x7adf85ff._0x532fee19(_0x90544239), this._0x7adf85ff._0xe1c096e1(_0x90544239));
            int _0x9faaca59 = _0x90544239;
            _0x1fcb18a4._0xdc1b0efc.onClick.AddListener(() => this._0xb5a469ff(_0x9faaca59));
            this._0x42dfa1dc[_0x90544239] = _0x1fcb18a4;
        }
    }

    private _0x50225373 _0x79e3c98c;
    private void _0x23cd0220()
    {
        int _0xf1f7d6db = this._0x7adf85ff._0x2d5857e0();
        for (int _0x780e8c02 = 0; _0x780e8c02 < this._0x42dfa1dc.Length; _0x780e8c02++)
        {
            if (this._0x42dfa1dc[_0x780e8c02] != null)
            {
                this._0x42dfa1dc[_0x780e8c02]._0x2d224397(_0x780e8c02 == _0xf1f7d6db);
            }
        }
    }

    // -- Trail Vault ---------------------------------------------------------------
    private void _0x41feabdd(RectTransform _0xd781c4d7)
    {
        _0x29ecbd6a.Scrim(_0xd781c4d7, _0x25be1630._0x4de58997(new byte[9] { 54, 1, 21, 12, 20, 54, 5, 9, 12 }, 96), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Night, 0.82f), true);
        _0x29ecbd6a.Card(_0xd781c4d7, _0x25be1630._0x4de58997(new byte[9] { 197, 242, 230, 255, 231, 208, 242, 225, 247 }, 147), new Vector2(_0x531552b7.PanelCx, 1400f), new Vector2(1080f, 1180f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Deep, 0.98f), _0x2ac8856b.Gold, 1.35f, 5f);
        _0x29ecbd6a.Label(_0xd781c4d7, _0x25be1630._0x4de58997(new byte[11] { 69, 114, 102, 127, 103, 91, 118, 114, 119, 118, 97 }, 19), new Vector2(_0x531552b7.PanelCx, 1900f), new Vector2(880f, 80f), this._0x76792631, _0x25be1630._0x4de58997(new byte[11] { 117, 96, 104, 109, 1, 117, 115, 96, 104, 109, 114 }, 33), _0x531552b7.SizeSection, _0x531552b7.SizeSectionMin, 62f, _0x2ac8856b.Gold, TextAlignmentOptions.Center);
        this._0x9587a4ca(_0xd781c4d7);
        this._0x140a8da3(_0xd781c4d7, _0x25be1630._0x4de58997(new byte[10] { 195, 244, 224, 249, 225, 214, 249, 250, 230, 240 }, 149), new Vector2(1060f, 1930f), () => this._0x37f2c787());
        this._0x23cd0220();
    }

    private _0xeb727ff5[] _0x42dfa1dc = new _0xeb727ff5[0];
    private void OnDestroy()
    {
        DOTween.Kill(this._0x8f9f5577);
        DOTween.Kill(this._0xb2b5b615);
    }

    private void _0x72deb9a8()
    {
        bool _0x61a6e68b = !this._0x7adf85ff._0xb36b7342();
        this._0x7adf85ff._0x76effd92(_0x61a6e68b);
        this._0xb5a4ea61._0xbdf4c35a(_0x61a6e68b, true);
        if (_0x61a6e68b)
        {
            DOTween.Kill(this._0x8f9f5577);
            if (this._0x8f9f5577 != null)
            {
                this._0x8f9f5577.localEulerAngles = Vector3.zero;
            }
        }
        else
        {
            this._0x98f33894(false);
        }
    }

    private Button _0xbbe97240(RectTransform _0x19c2b147, string _0x81c79241, Vector2 _0x48d9fc0d, string _0x2afbb230, UnityAction _0xd8c3503b)
    {
        Image _0x3909dfe2 = _0x29ecbd6a.Card(_0x19c2b147, _0x81c79241, _0x48d9fc0d, new Vector2(360f, 120f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Deep, 0.95f), _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.8f), 1.3f, 4f);
        _0x29ecbd6a.Label(_0x19c2b147, _0x81c79241, _0x48d9fc0d, new Vector2(320f, 70f), this._0x76792631, _0x2afbb230, _0x531552b7.SizeBody, _0x531552b7.SizeBodyMin, 48f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
        Button _0x05d9e4ad = _0x29ecbd6a.Tap(_0x3909dfe2);
        _0x05d9e4ad.onClick.AddListener(() => _0xd8c3503b());
        return _0x05d9e4ad;
    }

    private _0xadc65cb2 _0x76792631;
    private const float RailCy = 1560f;
    private static readonly string[] _0xbbac0c2c =
    {
        _0x25be1630._0x4de58997(new byte[5] { 67, 75, 68, 67, 84 }, 6),
        _0x25be1630._0x4de58997(new byte[5] { 119, 108, 99, 100, 115 }, 54),
        _0x25be1630._0x4de58997(new byte[6] { 44, 51, 53, 54, 63, 46 }, 122),
        _0x25be1630._0x4de58997(new byte[6] { 220, 212, 215, 223, 222, 213 }, 155),
        _0x25be1630._0x4de58997(new byte[4] { 7, 4, 26, 29 }, 83),
        _0x25be1630._0x4de58997(new byte[6] { 248, 236, 235, 246, 235, 248 }, 185)
    };
    private RectTransform _0xec32760f;
    private void _0x0d2dbe8e()
    {
        bool _0x5cb51425 = !this._0x7adf85ff._0x53f9335d();
        this._0x7adf85ff._0x4d3f8a4c(_0x5cb51425);
        this._0x4b0a67f0._0xbdf4c35a(_0x5cb51425, true);
    }

    private _0x16a559e2 _0x7adf85ff;
    private RectTransform _0x931fba4c;
    private TextMeshProUGUI _0xd173f147;
    private static readonly Color[] _0xbd8997f5 =
    {
        new Color(0.976f, 0.482f, 0.263f, 1f),
        new Color(0.086f, 0.541f, 0.678f, 1f),
        new Color(0.608f, 0.365f, 0.898f, 1f),
        new Color(0.976f, 0.780f, 0.310f, 1f),
        new Color(0.435f, 0.827f, 0.910f, 1f),
        new Color(0.780f, 0.643f, 0.961f, 1f)
    };
    private void _0x39c2b988()
    {
        int _0xcde402f3 = Mathf.Clamp(this._0x7adf85ff._0x2d5857e0(), 0, _0xbd8997f5.Length - 1);
        if (this._0xb2b5b615 != null)
        {
            this._0xb2b5b615.DOColor(_0xbd8997f5[_0xcde402f3], 0.22f).SetLink(this._0xb2b5b615.gameObject);
        }
    }

    /// <summary>
    /// Rocks, never rotates. A preview that turns a full circle changes an 8x8 thumbnail
    /// every poll, and the capture's "the screen has settled" wait then never finishes.
    /// </summary>
    public void _0x98f33894(bool _0x3d6d10ec)
    {
        if (_0x3d6d10ec || this._0x8f9f5577 == null)
        {
            return;
        }

        this._0x8f9f5577.DOLocalRotate(new Vector3(0f, 0f, 4f), 2.4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._0x8f9f5577.gameObject);
    }

    private void _0x140a8da3(RectTransform _0x76605b92, string _0xfcbf6253, Vector2 _0x57aec8c8, UnityAction _0xac8b41d0)
    {
        Image _0xa8a9598a = _0x29ecbd6a.Plate(_0x76605b92, _0xfcbf6253, _0x57aec8c8, _0x531552b7.Square(96f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Surface, 0.95f), 0.7f);
        _0x29ecbd6a.Picture(_0x76605b92, _0xfcbf6253, _0x57aec8c8, _0x531552b7.Square(52f), this._0x76792631.IconClose, _0x2ac8856b.Gold);
        _0x29ecbd6a.Tap(_0xa8a9598a).onClick.AddListener(() => _0xac8b41d0());
    }

    private void _0x30758429()
    {
        this._0x23cd0220();
        this._0xec32760f.gameObject.SetActive(true);
        this._0x12ff7ce0.gameObject.SetActive(false);
    }

    private void _0x86fbe709()
    {
        this._0x3a188f0c();
        this._0x12ff7ce0.gameObject.SetActive(true);
        this._0xec32760f.gameObject.SetActive(false);
    }

    private void _0x7796f19b()
    {
        int _0xeba16ccd = this._0x7adf85ff._0x72cb91c4();
        for (int _0x9a3bd32b = 0; _0x9a3bd32b < this._0x21327b36.Length; _0x9a3bd32b++)
        {
            if (this._0x21327b36[_0x9a3bd32b] != null)
            {
                this._0x21327b36[_0x9a3bd32b]._0x191d8e16(_0x9a3bd32b == _0xeba16ccd);
            }
        }

        int _0x88df60bd = this._0x7adf85ff._0xd5490c0f(_0xeba16ccd);
        if (_0x88df60bd > 0)
        {
            _0x6bdb9d59.SetText(this._0xd173f147, _0x25be1630._0x4de58997(new byte[5] { 18, 21, 3, 4, 112 }, 80) + _0x88df60bd.ToString() + _0x25be1630._0x4de58997(new byte[11] { 63, 50, 63, 92, 80, 74, 77, 76, 90, 63, 47 }, 31) + (_0xeba16ccd + 1).ToString());
            _0x6bdb9d59.Tint(this._0xd173f147, _0x2ac8856b.Cream);
        }
        else
        {
            _0x6bdb9d59.SetText(this._0xd173f147, _0x25be1630._0x4de58997(new byte[20] { 196, 197, 170, 204, 198, 195, 205, 194, 222, 170, 198, 197, 205, 205, 207, 206, 170, 211, 207, 222 }, 138));
            _0x6bdb9d59.Tint(this._0xd173f147, _0x2ac8856b.Muted);
        }

        _0x6bdb9d59.SetText(this._0x958a244c, _0x014c750c._0x197748fa._0x43e96ed6.ToString());
        this._0x39c2b988();
    }

    private Image _0xb2b5b615;
    private void _0xfcf051ac(int _0x665fd3c3)
    {
        if (!this._0x7adf85ff._0x99f01839(_0x665fd3c3))
        {
            return;
        }

        this._0x7adf85ff._0xed1aa910(_0x665fd3c3);
        this._0x7796f19b();
    }

    private void _0x9d8e4a39()
    {
        this._0x7adf85ff._0x820ef773();
        _0x014c750c._0x197748fa._0x43e96ed6 = 0;
        this._0x3a188f0c();
        for (int _0xe62ae714 = 0; _0xe62ae714 < this._0x21327b36.Length; _0xe62ae714++)
        {
            if (this._0x21327b36[_0xe62ae714] != null)
            {
                Destroy(this._0x21327b36[_0xe62ae714].gameObject);
            }
        }

        this._0x37b1c006();
        this._0x7796f19b();
        this._0x3b8c62e7();
    }

    private void _0x3a188f0c()
    {
        if (this._0x931fba4c != null)
        {
            this._0x931fba4c.gameObject.SetActive(false);
        }
    }

    private const float PlayCy = 889.7f;
    /// <summary>A reset relocks every trail, so the vault's badges have to be rebuilt too.</summary>
    private void _0x3b8c62e7()
    {
        for (int _0x62d19c71 = 0; _0x62d19c71 < this._0x42dfa1dc.Length; _0x62d19c71++)
        {
            if (this._0x42dfa1dc[_0x62d19c71] != null)
            {
                Destroy(this._0x42dfa1dc[_0x62d19c71].gameObject);
            }
        }

        this._0x7adf85ff._0x6fa7d0d1(0);
        this._0x9587a4ca(this._0xec32760f);
        this._0x23cd0220();
        this._0x39c2b988();
    }

    private const float CardW = 206f;
    private _0xf6a1b425[] _0x246fb572;
    public void _0x8f78216d(RectTransform _0x92b95029, _0xadc65cb2 _0x1ef23108, _0x16a559e2 _0x3878dd87, _0xf6a1b425[] _0xc08b6dcd)
    {
        this._0x76792631 = _0x1ef23108;
        this._0x7adf85ff = _0x3878dd87;
        this._0x246fb572 = _0xc08b6dcd;
        this._0xacb83996 = _0x29ecbd6a.Layer(_0x92b95029, _0x25be1630._0x4de58997(new byte[10] { 247, 207, 221, 233, 197, 212, 246, 203, 203, 208 }, 164));
        this._0xf338ec18(this._0xacb83996);
        this._0xec32760f = _0x29ecbd6a.Layer(_0x92b95029, _0x25be1630._0x4de58997(new byte[9] { 121, 78, 90, 67, 91, 125, 64, 64, 91 }, 47));
        this._0x41feabdd(this._0xec32760f);
        this._0xec32760f.gameObject.SetActive(false);
        this._0x12ff7ce0 = _0x29ecbd6a.Layer(_0x92b95029, _0x25be1630._0x4de58997(new byte[12] { 30, 40, 57, 57, 36, 35, 42, 62, 31, 34, 34, 57 }, 77));
        this._0xa6a562b5(this._0x12ff7ce0);
        this._0x12ff7ce0.gameObject.SetActive(false);
        this._0x7796f19b();
    }

    private int _0x38abc25f(int _0x863afb6d)
    {
        if (this._0x246fb572 != null && _0x863afb6d >= 0 && _0x863afb6d < this._0x246fb572.Length && this._0x246fb572[_0x863afb6d] != null)
        {
            return this._0x246fb572[_0x863afb6d].Gates;
        }

        return 18;
    }

    private void _0x7d8a2ae4()
    {
        if (this._0x931fba4c != null)
        {
            this._0x931fba4c.gameObject.SetActive(true);
        }
    }

    // -- Settings ------------------------------------------------------------------
    private void _0xa6a562b5(RectTransform _0x59137032)
    {
        _0x29ecbd6a.Scrim(_0x59137032, _0x25be1630._0x4de58997(new byte[12] { 99, 85, 68, 68, 89, 94, 87, 67, 102, 85, 89, 92 }, 48), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Night, 0.82f), true);
        _0x29ecbd6a.Card(_0x59137032, _0x25be1630._0x4de58997(new byte[12] { 112, 70, 87, 87, 74, 77, 68, 80, 96, 66, 81, 71 }, 35), new Vector2(_0x531552b7.PanelCx, 1400f), new Vector2(1080f, 820f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Deep, 0.98f), _0x2ac8856b.Gold, 1.35f, 5f);
        _0x29ecbd6a.Label(_0x59137032, _0x25be1630._0x4de58997(new byte[14] { 108, 90, 75, 75, 86, 81, 88, 76, 119, 90, 94, 91, 90, 77 }, 63), new Vector2(_0x531552b7.PanelCx, 1740f), new Vector2(760f, 80f), this._0x76792631, _0x25be1630._0x4de58997(new byte[15] { 68, 78, 75, 69, 74, 86, 34, 81, 71, 86, 86, 75, 76, 69, 81 }, 2), _0x531552b7.SizeSection, _0x531552b7.SizeSectionMin, 62f, _0x2ac8856b.Gold, TextAlignmentOptions.Center);
        this._0xb5a4ea61 = this._0xf4bdf4e1(_0x59137032, _0x25be1630._0x4de58997(new byte[14] { 230, 241, 240, 225, 247, 241, 240, 148, 249, 251, 224, 253, 251, 250 }, 180), 1600f, this._0x7adf85ff._0xb36b7342(), () => this._0x72deb9a8());
        this._0x4b0a67f0 = this._0xf4bdf4e1(_0x59137032, _0x25be1630._0x4de58997(new byte[11] { 162, 185, 190, 183, 208, 183, 165, 185, 180, 181, 163 }, 240), 1452f, this._0x7adf85ff._0x53f9335d(), () => this._0x0d2dbe8e());
        this._0x79e3c98c = this._0xf4bdf4e1(_0x59137032, _0x25be1630._0x4de58997(new byte[7] { 99, 106, 123, 127, 98, 104, 120 }, 43), 1304f, this._0x7adf85ff._0x7c8bba6e(), () => this._0x79c820b5());
        Image _0xe4ff32bd = _0x29ecbd6a.Card(_0x59137032, _0x25be1630._0x4de58997(new byte[11] { 56, 15, 25, 15, 30, 40, 31, 30, 30, 5, 4 }, 106), new Vector2(_0x531552b7.PanelCx, 1150f), new Vector2(560f, 112f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Surface, 0.95f), _0x2ac8856b.Faded(_0x2ac8856b.Gold, 0.8f), 1.3f, 4f);
        _0x29ecbd6a.Label(_0x59137032, _0x25be1630._0x4de58997(new byte[10] { 31, 40, 62, 40, 57, 1, 44, 47, 40, 33 }, 77), new Vector2(_0x531552b7.PanelCx, 1150f), new Vector2(520f, 66f), this._0x76792631, _0x25be1630._0x4de58997(new byte[16] { 98, 117, 99, 117, 100, 16, 118, 124, 121, 119, 120, 100, 16, 124, 127, 119 }, 48), _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 44f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
        _0x29ecbd6a.Tap(_0xe4ff32bd).onClick.AddListener(() => this._0x7d8a2ae4());
        this._0x931fba4c = _0x29ecbd6a.Node(_0x59137032, _0x25be1630._0x4de58997(new byte[10] { 123, 87, 86, 94, 81, 74, 85, 106, 87, 79 }, 56), new Vector2(_0x531552b7.PanelCx, 1040f), new Vector2(1000f, 120f));
        _0x29ecbd6a.Label(this._0x931fba4c, _0x25be1630._0x4de58997(new byte[12] { 181, 153, 152, 144, 159, 132, 155, 186, 151, 148, 147, 154 }, 246), new Vector2(240f, 60f), new Vector2(440f, 66f), this._0x76792631, _0x25be1630._0x4de58997(new byte[19] { 52, 35, 48, 34, 52, 81, 52, 39, 52, 35, 40, 81, 35, 52, 50, 62, 35, 53, 78 }, 113), _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 42f, _0x2ac8856b.Sky, TextAlignmentOptions.Left);
        Image _0x193380b0 = _0x29ecbd6a.Card(this._0x931fba4c, _0x25be1630._0x4de58997(new byte[10] { 227, 207, 206, 198, 201, 210, 205, 249, 197, 211 }, 160), new Vector2(640f, 60f), new Vector2(230f, 96f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Violet, 0.9f), _0x2ac8856b.Gold, 1.3f, 4f);
        _0x29ecbd6a.Label(this._0x931fba4c, _0x25be1630._0x4de58997(new byte[15] { 203, 231, 230, 238, 225, 250, 229, 209, 237, 251, 196, 233, 234, 237, 228 }, 136), new Vector2(640f, 60f), new Vector2(200f, 60f), this._0x76792631, _0x25be1630._0x4de58997(new byte[7] { 135, 139, 138, 130, 141, 150, 137 }, 196), _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 42f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
        _0x29ecbd6a.Tap(_0x193380b0).onClick.AddListener(() => this._0x9d8e4a39());
        Image _0xe4d32636 = _0x29ecbd6a.Card(this._0x931fba4c, _0x25be1630._0x4de58997(new byte[9] { 113, 93, 92, 84, 91, 64, 95, 124, 93 }, 50), new Vector2(880f, 60f), new Vector2(200f, 96f), this._0x76792631.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Deep, 0.95f), _0x2ac8856b.Faded(_0x2ac8856b.Azure, 0.8f), 1.3f, 4f);
        _0x29ecbd6a.Label(this._0x931fba4c, _0x25be1630._0x4de58997(new byte[14] { 111, 67, 66, 74, 69, 94, 65, 98, 67, 96, 77, 78, 73, 64 }, 44), new Vector2(880f, 60f), new Vector2(180f, 60f), this._0x76792631, _0x25be1630._0x4de58997(new byte[4] { 73, 71, 71, 82 }, 2), _0x531552b7.SizeCaption, _0x531552b7.SizeCaptionMin, 42f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
        _0x29ecbd6a.Tap(_0xe4d32636).onClick.AddListener(() => this._0x3a188f0c());
        this._0x931fba4c.gameObject.SetActive(false);
        this._0x140a8da3(_0x59137032, _0x25be1630._0x4de58997(new byte[13] { 106, 92, 77, 77, 80, 87, 94, 74, 122, 85, 86, 74, 92 }, 57), new Vector2(1060f, 1740f), () => this._0x37f2c787());
    }

    private _0x6ea8d464[] _0x21327b36 = new _0x6ea8d464[0];
    private void _0x79c820b5()
    {
        bool _0x6aaa6b3a = !this._0x7adf85ff._0x7c8bba6e();
        this._0x7adf85ff._0xf8fed59e(_0x6aaa6b3a);
        this._0x79e3c98c._0xbdf4c35a(_0x6aaa6b3a, true);
        if (_0x6aaa6b3a)
        {
            Handheld.Vibrate();
        }
    }
}

internal static class _0x25be1630
{
    internal static string _0x4de58997(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}