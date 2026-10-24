using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The UGUI factory for this game. Everything is drawn as uGUI inside the template's own
/// panel body, so there is not a single SpriteRenderer in the project and the camera is
/// never the frame of reference - SkyMetrics is.
///
/// Placement convention, identical to the design document: anchors collapsed to the
/// parent's BOTTOM-LEFT, pivot centred, anchoredPosition = the element's centre in panel
/// space (x from the left, y from the bottom of 1242x2688).
///
/// Draw order is hierarchy order (C.13): whatever is built LATER draws on top, so a plate
/// that surrounds content is always built BEFORE that content.
/// </summary>
public static class _0x29ecbd6a
{
    /// <summary>
    /// A horizontal bar: a dark track plus a fill pinned to the track's left edge, so the
    /// fill width is the value and nothing depends on a driven anchor.
    /// </summary>
    public static Image Bar(RectTransform _0xbf103213, string _0x324a4bf0, Vector2 _0x4e54309c, Vector2 _0xb5673881, Sprite _0xe1e69858, Color _0x27bc55e5, Color _0xb387a794, float _0xfdf85494)
    {
        Plate(_0xbf103213, _0x324a4bf0, _0x4e54309c, _0xb5673881, _0xe1e69858, _0x27bc55e5, 1.4f);
        float _0x4e6c8315 = _0xb5673881.x - (_0xfdf85494 * 2f);
        float _0x16c5f70f = _0xb5673881.y - (_0xfdf85494 * 2f);
        RectTransform _0x1b5aab00 = Node(_0xbf103213, _0x324a4bf0, _0x4e54309c, new Vector2(_0x4e6c8315, _0x16c5f70f));
        _0x1b5aab00.pivot = new Vector2(0f, 0.5f);
        _0x1b5aab00.anchoredPosition = new Vector2(_0x4e54309c.x - (_0x4e6c8315 * 0.5f), _0x4e54309c.y);
        Image _0x120437c7 = _0x1b5aab00.gameObject.AddComponent<Image>();
        _0x120437c7.sprite = _0xe1e69858;
        _0x120437c7.type = Image.Type.Sliced;
        _0x120437c7.pixelsPerUnitMultiplier = 1.4f;
        _0x120437c7.color = _0xb387a794;
        _0x120437c7.raycastTarget = false;
        return _0x120437c7;
    }

    /// <summary>
    /// A framed card: the rim plate is built FIRST so it sits beneath the body (C.13 - a
    /// frame that surrounds content is never added on top of it), and the body is inset by
    /// the rim width, so what shows is a border and not a tint over the whole card.
    /// Returns the BODY, which is what a caller wants to animate or recolour.
    /// </summary>
    public static Image Card(RectTransform _0x7b748917, string _0xc5f4db05, Vector2 _0x0b526083, Vector2 _0x50811258, Sprite _0xd8591cfe, Color _0xe119ad1d, Color _0x19578d01, float _0xcd91baf4, float _0x910f00de)
    {
        Plate(_0x7b748917, _0xc5f4db05, _0x0b526083, _0x50811258, _0xd8591cfe, _0x19578d01, _0xcd91baf4);
        Vector2 _0x61df9921 = new Vector2(Mathf.Max(_0x50811258.x - (_0x910f00de * 2f), 8f), Mathf.Max(_0x50811258.y - (_0x910f00de * 2f), 8f));
        return Plate(_0x7b748917, _0xc5f4db05, _0x0b526083, _0x61df9921, _0xd8591cfe, _0xe119ad1d, _0xcd91baf4 * 1.05f);
    }

    /// <summary>A plate stretched over the whole parent - scrims, vignettes, backdrops.</summary>
    public static Image Scrim(RectTransform _0x39a0797a, string _0x460d9601, Sprite _0x07af977a, Color _0xbc230402, bool _0x3c0fe37c)
    {
        RectTransform _0x8bb104be = Layer(_0x39a0797a, _0x460d9601);
        Image _0xd11d2ae5 = _0x8bb104be.gameObject.AddComponent<Image>();
        _0xd11d2ae5.sprite = _0x07af977a;
        _0xd11d2ae5.type = Image.Type.Sliced;
        _0xd11d2ae5.pixelsPerUnitMultiplier = 1f;
        _0xd11d2ae5.color = _0xbc230402;
        _0xd11d2ae5.raycastTarget = _0x3c0fe37c;
        return _0xd11d2ae5;
    }

    /// <summary>A plate that fills its parent minus a uniform margin - the body of a frame.</summary>
    public static Image Inset(RectTransform _0xc9d51d3a, string _0xf846fbe6, float _0x98076030, Sprite _0xadd9eca3, Color _0x94cdfc54, float _0x2bb2af7e)
    {
        RectTransform _0xe4f44f96 = Layer(_0xc9d51d3a, _0xf846fbe6);
        _0xe4f44f96.offsetMin = new Vector2(_0x98076030, _0x98076030);
        _0xe4f44f96.offsetMax = new Vector2(-_0x98076030, -_0x98076030);
        Image _0xf74c947e = _0xe4f44f96.gameObject.AddComponent<Image>();
        _0xf74c947e.sprite = _0xadd9eca3;
        _0xf74c947e.type = Image.Type.Sliced;
        _0xf74c947e.pixelsPerUnitMultiplier = _0x2bb2af7e;
        _0xf74c947e.color = _0x94cdfc54;
        _0xf74c947e.raycastTarget = false;
        return _0xf74c947e;
    }

    /// <summary>A 9-slice plate. The multiplier is the corner-radius lever: lower = rounder.</summary>
    public static Image Plate(RectTransform _0x6291a20e, string _0xd505d541, Vector2 _0xed991a0e, Vector2 _0xfef2dd54, Sprite _0x603bba4a, Color _0x8be1ff23, float _0xb9d9dda5)
    {
        RectTransform _0xb6b6e79a = Node(_0x6291a20e, _0xd505d541, _0xed991a0e, _0xfef2dd54);
        Image _0x9598c2fc = _0xb6b6e79a.gameObject.AddComponent<Image>();
        _0x9598c2fc.sprite = _0x603bba4a;
        _0x9598c2fc.type = Image.Type.Sliced;
        _0x9598c2fc.pixelsPerUnitMultiplier = _0xb9d9dda5;
        _0x9598c2fc.color = _0x8be1ff23;
        _0x9598c2fc.raycastTarget = false;
        return _0x9598c2fc;
    }

    /// <summary>
    /// A content sprite. preserveAspect is always on: the generated PNGs are square, and
    /// letting a rectangle stretch one is the "the ball turned into an egg" defect (F.2a).
    /// </summary>
    public static Image Picture(RectTransform _0x93a26799, string _0x2d7ce7be, Vector2 _0xc6937c8a, Vector2 _0x52b0ab1e, Sprite _0x6222977b, Color _0x117c3ba8)
    {
        RectTransform _0x0bcc9836 = Node(_0x93a26799, _0x2d7ce7be, _0xc6937c8a, _0x52b0ab1e);
        Image _0x496d6290 = _0x0bcc9836.gameObject.AddComponent<Image>();
        _0x496d6290.sprite = _0x6222977b;
        _0x496d6290.type = Image.Type.Simple;
        _0x496d6290.preserveAspect = true;
        _0x496d6290.color = _0x117c3ba8;
        _0x496d6290.raycastTarget = false;
        return _0x496d6290;
    }

    /// <summary>
    /// Turns a plate into a real button. The plate itself is the raycast target, so the
    /// label drawn on top of it (raycastTarget off) never swallows the tap.
    /// </summary>
    public static Button Tap(Image _0xe5adb1dd)
    {
        _0xe5adb1dd.raycastTarget = true;
        Button _0x09045057 = _0xe5adb1dd.gameObject.AddComponent<Button>();
        _0x09045057.targetGraphic = _0xe5adb1dd;
        _0x09045057.transition = Selectable.Transition.ColorTint;
        ColorBlock _0x61a2a613 = _0x09045057.colors;
        _0x61a2a613.normalColor = Color.white;
        _0x61a2a613.highlightedColor = Color.white;
        _0x61a2a613.pressedColor = new Color(0.72f, 0.78f, 0.86f, 1f);
        _0x61a2a613.selectedColor = Color.white;
        _0x61a2a613.disabledColor = new Color(1f, 1f, 1f, 0.45f);
        _0x61a2a613.fadeDuration = 0.08f;
        _0x09045057.colors = _0x61a2a613;
        return _0x09045057;
    }

    public static RectTransform Node(RectTransform _0xc51c36a0, string _0x679e38a6, Vector2 _0xb0aadc61, Vector2 _0xedc88be4)
    {
        GameObject _0x8b5f5ead = new GameObject(_0x679e38a6, typeof(RectTransform));
        RectTransform _0x3582e624 = _0x8b5f5ead.GetComponent<RectTransform>();
        _0x3582e624.SetParent(_0xc51c36a0, false);
        _0x3582e624.anchorMin = Vector2.zero;
        _0x3582e624.anchorMax = Vector2.zero;
        _0x3582e624.pivot = new Vector2(0.5f, 0.5f);
        _0x3582e624.sizeDelta = _0xedc88be4;
        _0x3582e624.anchoredPosition = _0xb0aadc61;
        _0x3582e624.localScale = Vector3.one;
        return _0x3582e624;
    }

    /// <summary>Resizes a left-pinned bar fill to a 0..1 ratio of its full width.</summary>
    public static void SetBar(Image _0x80128a61, float _0xccfe4df2, float _0x79048843)
    {
        if (_0x80128a61 == null)
        {
            return;
        }

        RectTransform _0x6f50e6c4 = _0x80128a61.rectTransform;
        float _0x3d68f811 = Mathf.Clamp01(_0x79048843);
        _0x6f50e6c4.sizeDelta = new Vector2(Mathf.Max(_0xccfe4df2 * _0x3d68f811, 2f), _0x6f50e6c4.sizeDelta.y);
    }

    public static TextMeshProUGUI Label(RectTransform _0x6404f3ed, string _0x98c0d614, Vector2 _0x1ca88fe7, Vector2 _0x958aa2f8, _0xadc65cb2 _0x20f85f36, string _0x87cb6e27, float _0x1c732b21, float _0x02535ed0, float _0x2e88029b, Color _0x2e9acbb6, TextAlignmentOptions _0xea275500)
    {
        RectTransform _0x882c49b4 = Node(_0x6404f3ed, _0x98c0d614, _0x1ca88fe7, _0x958aa2f8);
        TextMeshProUGUI _0x3623d409 = _0x882c49b4.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x20f85f36 != null && _0x20f85f36.Font != null)
        {
            _0x3623d409.font = _0x20f85f36.Font;
        }

        _0x3623d409.text = _0x87cb6e27;
        _0x3623d409.fontSize = _0x1c732b21;
        _0x3623d409.alignment = _0xea275500;
        _0x3623d409.raycastTarget = false;
        _0x3623d409.color = _0x2e9acbb6;
        _0x6bdb9d59.ApplyFlow(_0x3623d409, _0x02535ed0, _0x2e88029b);
        _0x6bdb9d59.ApplyOutline(_0x3623d409);
        return _0x3623d409;
    }

    /// <summary>A child that fills its parent exactly - used for backdrops and layers.</summary>
    public static RectTransform Layer(RectTransform _0x80b4d569, string _0x898f4b24)
    {
        GameObject _0x3dd2e5b7 = new GameObject(_0x898f4b24, typeof(RectTransform));
        RectTransform _0xf512eee1 = _0x3dd2e5b7.GetComponent<RectTransform>();
        _0xf512eee1.SetParent(_0x80b4d569, false);
        _0xf512eee1.anchorMin = Vector2.zero;
        _0xf512eee1.anchorMax = Vector2.one;
        _0xf512eee1.pivot = new Vector2(0.5f, 0.5f);
        _0xf512eee1.offsetMin = Vector2.zero;
        _0xf512eee1.offsetMax = Vector2.zero;
        _0xf512eee1.localScale = Vector3.one;
        return _0xf512eee1;
    }
}