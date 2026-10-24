using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The dragon's tail: a fixed pool of motes that follow its recorded positions with a
/// fading alpha ramp. Pooled, never spawned per frame, and tinted to the chosen trail.
/// </summary>
public sealed class _0xea91f29d : MonoBehaviour
{
    private readonly Vector2[] _0x9bdb79a7 = new Vector2[MoteCount];
    private void _0xdc1b3e95()
    {
        for (int _0x1bb0f80d = 0; _0x1bb0f80d < this._0x65eb9e44.Length; _0x1bb0f80d++)
        {
            RectTransform _0xad5c598d = this._0x65eb9e44[_0x1bb0f80d];
            if (_0xad5c598d == null || this._0x9bdb79a7[_0x1bb0f80d] == Vector2.zero)
            {
                continue;
            }

            _0xad5c598d.anchoredPosition = this._0x9bdb79a7[_0x1bb0f80d];
        }
    }

    private Image[] _0xeff3beb0 = new Image[0];
    private Color _0x555c9c19 = Color.white;
    private const float SampleSeconds = 0.035f;
    public void _0xffe7e26f(Color _0x69cfc455, bool _0x7f5aab51)
    {
        this._0x555c9c19 = _0x69cfc455;
        this._0x202a8dfe = _0x7f5aab51 ? MoteCount / 2 : MoteCount;
        for (int _0xf2e2e4b2 = 0; _0xf2e2e4b2 < this._0xeff3beb0.Length; _0xf2e2e4b2++)
        {
            Image _0x773fc196 = this._0xeff3beb0[_0xf2e2e4b2];
            if (_0x773fc196 == null)
            {
                continue;
            }

            bool _0x61ff5b3a = _0xf2e2e4b2 < this._0x202a8dfe;
            _0x773fc196.gameObject.SetActive(_0x61ff5b3a);
            float _0xbb01f41e = 1f - ((float)_0xf2e2e4b2 / MoteCount);
            _0x773fc196.color = _0x2ac8856b.Faded(_0x69cfc455, 0.9f * _0xbb01f41e);
        }
    }

    private int _0x202a8dfe;
    public void _0x3624fecc(Vector2 _0x831fbf3f, float delta, bool _0x9c1ce4ce)
    {
        this._0x90525df8 += delta;
        if (this._0x90525df8 < SampleSeconds)
        {
            this._0xdc1b3e95();
            return;
        }

        this._0x90525df8 = 0f;
        for (int _0xf05f9d12 = this._0x9bdb79a7.Length - 1; _0xf05f9d12 > 0; _0xf05f9d12--)
        {
            this._0x9bdb79a7[_0xf05f9d12] = this._0x9bdb79a7[_0xf05f9d12 - 1];
        }

        this._0x9bdb79a7[0] = _0x831fbf3f;
        this._0xdc1b3e95();
    }

    private const int MoteCount = 14;
    private RectTransform[] _0x65eb9e44 = new RectTransform[0];
    public void _0xb7641a99(RectTransform _0x474c6c5d, _0xadc65cb2 _0xefc80ded, Image _0xf2f3312b, Color _0xf4777130)
    {
        this._0x555c9c19 = _0xf4777130;
        this._0xeff3beb0 = new Image[MoteCount];
        this._0x65eb9e44 = new RectTransform[MoteCount];
        float _0xbc2b37ea = _0x531552b7.DragonH * 0.26f;
        for (int _0xf5d9fa77 = 0; _0xf5d9fa77 < MoteCount; _0xf5d9fa77++)
        {
            Image _0x42f840fe = Instantiate(_0xf2f3312b, _0x474c6c5d, false);
            _0x42f840fe.sprite = _0xefc80ded.Spark;
            _0x42f840fe.preserveAspect = true;
            _0x42f840fe.raycastTarget = false;
            RectTransform _0xf26bf805 = _0x42f840fe.rectTransform;
            _0xf26bf805.anchorMin = Vector2.zero;
            _0xf26bf805.anchorMax = Vector2.zero;
            _0xf26bf805.pivot = new Vector2(0.5f, 0.5f);
            float _0x567e6b52 = 1f - ((float)_0xf5d9fa77 / MoteCount);
            _0xf26bf805.sizeDelta = _0x531552b7.Square(_0xbc2b37ea * Mathf.Lerp(0.45f, 1f, _0x567e6b52));
            _0xf26bf805.anchoredPosition = new Vector2(_0x531552b7.PanelCx, _0x531552b7.DragonY);
            this._0x65eb9e44[_0xf5d9fa77] = _0xf26bf805;
            this._0xeff3beb0[_0xf5d9fa77] = _0x42f840fe;
        }

        this._0xffe7e26f(_0xf4777130, false);
    }

    private float _0x90525df8;
}