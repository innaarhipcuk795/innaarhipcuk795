using TMPro;
using UnityEngine;

/// <summary>
/// C.15: the template ships five tutorial panels carrying "Lorem Ipsum" and "HEADER". This
/// game explains its one gesture on the game screen instead, so the tutorial stays off
/// (SETUP_OBJECT.IsTutorialEnabled = 0) - but a panel nobody dressed must still not be able
/// to reach the screen with the template's placeholder on it.
///
/// The panels are reached by INDEX through the controller's public list
/// (SETTINGS.PANELS.TUTORIAL0 .. TUTORIAL6), never by name, and they are emptied rather
/// than deactivated: the controller addresses panels by index, so pulling one out of the
/// list would break navigation.
/// </summary>
public static class _0x1d944efa
{
    public static void Silence()
    {
        _0x84e527ab _0x16d37445 = _0x84e527ab.Instance;
        if (_0x16d37445 == null || _0x16d37445.Panels == null)
        {
            return;
        }

        Blank(_0x16d37445, _0x014c750c._0x50016d8c.TUTORIAL0);
        Blank(_0x16d37445, _0x014c750c._0x50016d8c.TUTORIAL1);
        Blank(_0x16d37445, _0x014c750c._0x50016d8c.TUTORIAL2);
        Blank(_0x16d37445, _0x014c750c._0x50016d8c.TUTORIAL3);
        Blank(_0x16d37445, _0x014c750c._0x50016d8c.TUTORIAL4);
        Blank(_0x16d37445, _0x014c750c._0x50016d8c.TUTORIAL5);
        Blank(_0x16d37445, _0x014c750c._0x50016d8c.TUTORIAL6);
    }

    private static void Blank(_0x84e527ab _0xe64c2571, int _0x91f43f7f)
    {
        if (_0x91f43f7f < 0 || _0x91f43f7f >= _0xe64c2571.Panels.Count)
        {
            return;
        }

        _0xabf57bd7 _0xee4ddfae = _0xe64c2571.Panels[_0x91f43f7f];
        if (_0xee4ddfae == null || _0xee4ddfae.Content == null)
        {
            return;
        }

        TMP_Text[] _0x5b93360f = _0xee4ddfae.Content.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x3998f655 = 0; _0x3998f655 < _0x5b93360f.Length; _0x3998f655++)
        {
            if (_0x5b93360f[_0x3998f655] != null)
            {
                _0x5b93360f[_0x3998f655].text = string.Empty;
            }
        }
    }
}