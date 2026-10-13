using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xe7a8f38f : MonoBehaviour
{
    private static _0xe7a8f38f _0x958abc1e;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x7b65e0ba(Object _0x7b10e499)
    {
        TMP_Text _0x799f624c = _0x7b10e499 as TMP_Text;
        if (_0x799f624c != null)
            this._0xab5f75e5.Add(_0x799f624c);
    }

    private readonly HashSet<TMP_Text> _0xab5f75e5 = new HashSet<TMP_Text>();
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x958abc1e != null)
            return;
        GameObject _0x3d36c929 = new GameObject(_0xf2e11672._0xf4ae521d(new byte[16] { 48, 9, 20, 39, 11, 10, 16, 22, 5, 23, 16, 35, 17, 5, 22, 0 }, 100));
        _0x3d36c929.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x3d36c929);
        _0x958abc1e = _0x3d36c929.AddComponent<_0xe7a8f38f>();
    }

    private const float TargetRatio = 7f;
    private readonly List<TMP_Text> _0x57a5c607 = new List<TMP_Text>();
    private static float Ratio(Color _0x326e8094, Color _0xec165d8f)
    {
        float _0x8cc3b760 = Luminance(_0x326e8094);
        float _0xfb13ef43 = Luminance(_0xec165d8f);
        return (Mathf.Max(_0x8cc3b760, _0xfb13ef43) + 0.05f) / (Mathf.Min(_0x8cc3b760, _0xfb13ef43) + 0.05f);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x7316a994;
    private void OnEnable()
    {
        if (this._0x7316a994 == null)
            this._0x7316a994 = _0x2b509841 => this._0x7b65e0ba(_0x2b509841);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x7316a994);
    }

    private const float MinOutlineWidth = 0.01f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x97c08a93)
    {
        return 0.2126f * Linear(_0x97c08a93.r) + 0.7152f * Linear(_0x97c08a93.g) + 0.0722f * Linear(_0x97c08a93.b);
    }

    private void LateUpdate()
    {
        if (this._0xab5f75e5.Count == 0)
            return;
        this._0x57a5c607.Clear();
        this._0x57a5c607.AddRange(this._0xab5f75e5);
        this._0xab5f75e5.Clear();
        for (int _0x90048e5d = 0; _0x90048e5d < this._0x57a5c607.Count; _0x90048e5d++)
            Fix(this._0x57a5c607[_0x90048e5d]);
    }

    private const float MinRatio = 4.5f;
    private static void Fix(TMP_Text _0xc2ad6ebc)
    {
        if (_0xc2ad6ebc == null || !_0xc2ad6ebc.isActiveAndEnabled)
            return;
        Material _0xc29a1c58 = _0xc2ad6ebc.fontSharedMaterial;
        if (_0xc29a1c58 == null || !_0xc29a1c58.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xc29a1c58.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xc29a1c58.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xb6298d5f = _0xc2ad6ebc.color;
        if (_0xb6298d5f.a <= 0f)
            return;
        Color _0x045791c4 = _0xc29a1c58.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xb6298d5f, _0x045791c4) >= MinRatio)
            return;
        Color _0xfee434c4 = Luminance(_0x045791c4) < 0.5f ? Color.white : Color.black;
        Color _0x86ee2347;
        if (Ratio(_0xfee434c4, _0x045791c4) < TargetRatio)
        {
            _0x86ee2347 = _0xfee434c4;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x422b4608 = 0f;
            float _0x748c1ee4 = 1f;
            for (int _0x0f5d8ad0 = 0; _0x0f5d8ad0 < 20; _0x0f5d8ad0++)
            {
                float _0x48bba266 = (_0x422b4608 + _0x748c1ee4) * 0.5f;
                if (Ratio(Color.Lerp(_0xb6298d5f, _0xfee434c4, _0x48bba266), _0x045791c4) >= TargetRatio)
                    _0x748c1ee4 = _0x48bba266;
                else
                    _0x422b4608 = _0x48bba266;
            }

            _0x86ee2347 = Color.Lerp(_0xb6298d5f, _0xfee434c4, _0x748c1ee4);
        }

        _0x86ee2347.a = _0xb6298d5f.a;
        _0xc2ad6ebc.color = _0x86ee2347;
    }

    private void OnDisable()
    {
        if (this._0x7316a994 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x7316a994);
    }

    private static float Linear(float _0x6f795ac4)
    {
        _0x6f795ac4 = Mathf.Clamp01(_0x6f795ac4);
        return _0x6f795ac4 <= 0.03928f ? _0x6f795ac4 / 12.92f : Mathf.Pow((_0x6f795ac4 + 0.055f) / 1.055f, 2.4f);
    }
}

internal static class _0xf2e11672
{
    internal static string _0xf4ae521d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}