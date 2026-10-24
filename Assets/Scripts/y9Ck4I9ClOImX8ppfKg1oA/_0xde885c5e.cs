using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The splash: an ABSTRACT mark, one functional line and the template's loading bar,
/// themed. No name appears anywhere - not as text and not inside the mark.
///
/// Nothing here loops. The capture tool decides the loader has finished by waiting for the
/// frame to stop changing, so a perpetual tween on the splash would hold every scenario at
/// step one until its ceiling.
///
/// The bar itself is the ANDROID-3578 trap: "Fill Area" stretches to its parent and then
/// insets itself by 30 units, so a root shorter than that renders zero pixels whatever the
/// colours are. The root is sized well above the inset AND the inner rects are re-stretched
/// afterwards, so the authored inset cannot apply.
/// </summary>
public sealed class _0xde885c5e : MonoBehaviour
{
    public void _0xc874029a(RectTransform _0x6852f0df, _0xadc65cb2 _0xa43010c9)
    {
        _0x29ecbd6a.Scrim(_0x6852f0df, _0xdfdb3fd7._0x3f6b7215(new byte[10] { 17, 50, 46, 35, 49, 42, 20, 39, 43, 46 }, 66), _0xa43010c9.Plate, _0x2ac8856b.Faded(_0x2ac8856b.Night, 0.62f), false);
        Image _0x28f49674 = _0x29ecbd6a.Picture(_0x6852f0df, _0xdfdb3fd7._0x3f6b7215(new byte[10] { 192, 227, 255, 242, 224, 251, 222, 242, 225, 248 }, 147), new Vector2(_0x531552b7.PanelCx, 1680f), _0x531552b7.Square(300f), _0xa43010c9.Mark, Color.white);
        _0x28f49674.color = _0x2ac8856b.Faded(Color.white, 0f);
        _0x28f49674.rectTransform.localScale = Vector3.one * 0.86f;
        _0x28f49674.DOFade(1f, 0.55f).SetLink(_0x28f49674.gameObject);
        _0x28f49674.rectTransform.DOScale(1f, 0.55f).SetEase(Ease.OutBack).SetLink(_0x28f49674.gameObject);
        _0x29ecbd6a.Label(_0x6852f0df, _0xdfdb3fd7._0x3f6b7215(new byte[10] { 227, 192, 220, 209, 195, 216, 252, 217, 222, 213 }, 176), new Vector2(_0x531552b7.PanelCx, 980f), new Vector2(1002f, 70f), _0xa43010c9, _0xdfdb3fd7._0x3f6b7215(new byte[21] { 9, 11, 28, 9, 24, 11, 16, 23, 30, 121, 13, 17, 28, 121, 26, 12, 11, 11, 28, 23, 13 }, 89), _0x531552b7.SizeBody, _0x531552b7.SizeBodyMin, 48f, _0x2ac8856b.Cream, TextAlignmentOptions.Center);
        this._0x41ef92db();
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
    }

    private const float BarWidth = 760f;
    private const float BarHeight = 64f;
    /// <summary>
    /// Themes the template's own loading bar: fill in the accent, track in a dark palette
    /// colour at full alpha - not the near-transparent default nobody can see.
    /// </summary>
    private void _0x41ef92db()
    {
        _0xe6b3ba0e _0xf6b0c8c8 = _0xe6b3ba0e.Instance;
        if (_0xf6b0c8c8 == null || _0xf6b0c8c8.AnimationSlider == null)
        {
            return;
        }

        Slider _0x927b2f56 = _0xf6b0c8c8.AnimationSlider;
        RectTransform _0x57b1cdaa = _0x927b2f56.fillRect;
        if (_0x57b1cdaa == null)
        {
            return;
        }

        RectTransform _0xbb87e902 = _0x57b1cdaa.parent as RectTransform;
        RectTransform _0x02a4d673 = _0x927b2f56.GetComponent<RectTransform>();
        if (_0x02a4d673 != null)
        {
            _0x02a4d673.sizeDelta = new Vector2(BarWidth, BarHeight);
        }

        // Re-stretch the inner rects so the prefab's -30 inset cannot collapse the bar.
        // Fill is never touched through anchors: Slider.UpdateVisuals rewrites them every
        // frame - only its offsets are ours.
        if (_0xbb87e902 != null)
        {
            _0xbb87e902.anchorMin = new Vector2(0f, 0f);
            _0xbb87e902.anchorMax = new Vector2(1f, 1f);
            _0xbb87e902.offsetMin = new Vector2(6f, 6f);
            _0xbb87e902.offsetMax = new Vector2(-6f, -6f);
            Image _0x615185bd = _0xbb87e902.GetComponent<Image>();
            if (_0x615185bd != null)
            {
                _0x615185bd.color = _0x2ac8856b.Deep;
            }
        }

        _0x57b1cdaa.offsetMin = new Vector2(0f, 0f);
        _0x57b1cdaa.offsetMax = new Vector2(0f, 0f);
        Image _0x603b068a = _0x57b1cdaa.GetComponent<Image>();
        if (_0x603b068a != null)
        {
            _0x603b068a.color = _0x2ac8856b.Gold;
        }
    }
}

internal static class _0xdfdb3fd7
{
    internal static string _0x3f6b7215(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}