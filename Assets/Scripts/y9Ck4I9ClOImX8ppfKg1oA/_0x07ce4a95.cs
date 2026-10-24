using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>
/// Dresses the three template pops (C.3). Every line is written in THIS game's language,
/// through the Pop component's own serialized text references - the one wiring obfuscation
/// cannot break, and the reason no name or traversal index appears here.
///
/// The buttons are left to the template drivers they already carry, each one captioned in
/// the scene by its template GROUP (BOT_BTNS_RIGHT = the action, BOT_BTNS_LEFT = Sky Map,
/// TOP_BTNS = the close cross), so a caption can never land on the cross (C.17):
///   win    right = NEXT COURSE (reloads the scene on the course stored by the director)
///   lose   right = FLY AGAIN   (reloads the scene)
///   pause  right = RESUME      (hides the pops and resumes play)
///   all    left  = SKY MAP     (loads scene 0)
/// </summary>
public sealed class _0x07ce4a95 : MonoBehaviour
{
    public void _0xb315c8d2(int _0x4279329c, int _0xe75a6190, float _0x01d0e2ec, int _0xd770c883)
    {
        _0x7e67a501 _0x0ddea61c = _0x17c8dcf5.Instance._0x72c529be(_0x014c750c._0xbaa4f890.PAUSE);
        this._0x9060ee33(_0x0ddea61c, _0x4485d792._0xc5e28f49(new byte[11] { 177, 187, 190, 176, 191, 163, 215, 191, 178, 187, 179 }, 247), _0x4485d792._0xc5e28f49(new byte[5] { 31, 25, 12, 29, 120 }, 88) + _0x4279329c.ToString() + _0x4485d792._0xc5e28f49(new byte[3] { 192, 207, 192 }, 224) + _0xe75a6190.ToString(), _0x4485d792._0xc5e28f49(new byte[7] { 82, 89, 80, 88, 95, 49, 105 }, 17) + _0x01d0e2ec.ToString(_0x4485d792._0xc5e28f49(new byte[3] { 3, 29, 3 }, 51)) + _0x4485d792._0xc5e28f49(new byte[10] { 229, 232, 229, 132, 128, 145, 141, 128, 151, 229 }, 197) + _0xd770c883.ToString() + _0x4485d792._0xc5e28f49(new byte[1] { 91 }, 126));
        _0x2bc80d8c.Instance._0x99ca33d7(false);
        _0x17c8dcf5.Instance._0xb2f8fd68(_0x014c750c._0xbaa4f890.PAUSE);
    }

    public void _0xb5a55daa(int _0x62f2bba9, int _0xfed63a52, int _0x0a0fccee, float _0x3c3e1f01, int _0x60dba46d)
    {
        _0x7e67a501 _0x7c806cba = _0x17c8dcf5.Instance._0x72c529be(_0x014c750c._0xbaa4f890.WIN);
        this._0x9060ee33(_0x7c806cba, _0x4485d792._0xc5e28f49(new byte[15] { 103, 107, 113, 118, 119, 97, 4, 112, 108, 118, 97, 101, 96, 97, 96 }, 36), _0x62f2bba9.ToString(), _0x4485d792._0xc5e28f49(new byte[6] { 121, 98, 101, 108, 120, 11 }, 43) + _0xfed63a52.ToString() + _0x4485d792._0xc5e28f49(new byte[3] { 159, 144, 159 }, 191) + _0x0a0fccee.ToString() + _0x4485d792._0xc5e28f49(new byte[15] { 53, 56, 53, 87, 80, 70, 65, 53, 86, 93, 84, 92, 91, 53, 109 }, 21) + _0x3c3e1f01.ToString(_0x4485d792._0xc5e28f49(new byte[3] { 222, 192, 222 }, 238)) + _0x4485d792._0xc5e28f49(new byte[4] { 95, 82, 95, 84 }, 127) + _0x60dba46d.ToString() + _0x4485d792._0xc5e28f49(new byte[7] { 230, 149, 142, 135, 148, 130, 149 }, 198));
        _0x17c8dcf5.Instance._0xb2f8fd68(_0x014c750c._0xbaa4f890.WIN);
    }

    public void _0x92d57583(int _0xfb982619, int _0x779e6315, int _0xec29d610, float _0xb2e9a43b, int _0x1569576a)
    {
        _0x7e67a501 _0x4839e8d0 = _0x17c8dcf5.Instance._0x72c529be(_0x014c750c._0xbaa4f890.LOSE);
        this._0x9060ee33(_0x4839e8d0, _0x4485d792._0xc5e28f49(new byte[12] { 158, 154, 139, 151, 154, 141, 255, 140, 143, 154, 145, 139 }, 223), _0xfb982619.ToString(), _0x4485d792._0xc5e28f49(new byte[5] { 167, 161, 180, 165, 192 }, 224) + _0x779e6315.ToString() + _0x4485d792._0xc5e28f49(new byte[3] { 182, 185, 182 }, 150) + _0xec29d610.ToString() + _0x4485d792._0xc5e28f49(new byte[15] { 228, 233, 228, 134, 129, 151, 144, 228, 135, 140, 133, 141, 138, 228, 188 }, 196) + _0xb2e9a43b.ToString(_0x4485d792._0xc5e28f49(new byte[3] { 176, 174, 176 }, 128)) + _0x4485d792._0xc5e28f49(new byte[4] { 127, 114, 127, 116 }, 95) + _0x1569576a.ToString() + _0x4485d792._0xc5e28f49(new byte[7] { 113, 2, 25, 16, 3, 21, 2 }, 81));
        _0x17c8dcf5.Instance._0xb2f8fd68(_0x014c750c._0xbaa4f890.LOSE);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
    }

    /// <summary>
    /// Header, body and the extra line. This template family leaves ContentAdditionalText
    /// unassigned on the pause pop, so every reference is guarded rather than assumed -
    /// writing all three "as documented" silently loses two on some families.
    /// </summary>
    private void _0x9060ee33(_0x7e67a501 _0x4bf538dc, string _0xf456529d, string _0x8b42e6f3, string _0xac16578a)
    {
        if (_0x4bf538dc == null)
        {
            return;
        }

        this._0xed6b2e92(_0x4bf538dc.ContentHeaderText, _0xf456529d, _0x2ac8856b.Gold, _0x531552b7.SizeHeroMin, 92f);
        this._0xed6b2e92(_0x4bf538dc.ContentMainText, _0x8b42e6f3, _0x2ac8856b.Cream, _0x531552b7.SizeBodyMin, 88f);
        this._0xed6b2e92(_0x4bf538dc.ContentAdditionalText, _0xac16578a, _0x2ac8856b.Sky, _0x531552b7.SizeCaptionMin, 60f);
    }

    private void _0xed6b2e92(TMP_Text _0xac70b510, string _0x111b3b08, Color _0x66410102, float _0x54215864, float _0xcb2a891f)
    {
        if (_0xac70b510 == null)
        {
            return;
        }

        _0x6bdb9d59.ApplyFlow(_0xac70b510, _0x54215864, _0xcb2a891f);
        _0x6bdb9d59.SetText(_0xac70b510, _0x111b3b08);
        _0x6bdb9d59.Tint(_0xac70b510, _0x66410102);
    }
}

internal static class _0x4485d792
{
    internal static string _0xc5e28f49(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}