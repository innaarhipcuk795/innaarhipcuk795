using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>One elemental ring of a gate. Spawned from a prefab that already carries its
/// Image, size and references - nothing is fixed up at runtime.</summary>
public sealed class _0x78f632c2 : MonoBehaviour
{
    public bool _0x49a7645e
    {
        get
        {
            return this._0x677cb8dd;
        }
    }

    /// <summary>The pass flash: the ring blooms and fades out where it was crossed.</summary>
    public void _0xf6337831(float _0x822d6604)
    {
        if (this._0x677cb8dd)
        {
            return;
        }

        this._0x677cb8dd = true;
        if (this._rect != null)
        {
            this._rect.DOScale(_0x822d6604 * 1.35f, 0.3f).SetEase(Ease.OutQuad).SetLink(this._rect.gameObject);
        }

        if (this._ring != null)
        {
            this._ring.DOFade(0f, 0.3f).SetLink(this._ring.gameObject);
        }

        if (this._halo != null)
        {
            this._halo.DOFade(0f, 0.3f).SetLink(this._halo.gameObject);
        }
    }

    [SerializeField]
    private Image _ring;
    private bool _0x677cb8dd;
    [SerializeField]
    private RectTransform _rect;
    private void OnDestroy()
    {
        DOTween.Kill(this._rect);
        DOTween.Kill(this._ring);
        DOTween.Kill(this._halo);
    }

    public _0x5afdf70c _0xf120a0da
    {
        get
        {
            return this._0xc71bd4ab;
        }
    }

    public void _0x6d40ca52(_0xadc65cb2 _0x56923096, _0x5afdf70c _0xdd5fbbc8, float _0xdf3739b4, bool _0x99e3dac5)
    {
        this._0xc71bd4ab = _0xdd5fbbc8;
        this._0x677cb8dd = false;
        if (this._rect != null)
        {
            this._rect.anchoredPosition = new Vector2(_0xdf3739b4, 0f);
            this._rect.sizeDelta = _0x531552b7.Square(_0x531552b7.RingOuter);
            this._rect.localScale = Vector3.one;
        }

        if (this._ring != null)
        {
            this._ring.sprite = _0x56923096._0x46ad98d8(_0xdd5fbbc8);
            this._ring.color = Color.white;
        }

        if (this._halo != null)
        {
            this._halo.sprite = _0x56923096.Plate;
            this._halo.color = _0x2ac8856b.Faded(_0x2ac8856b.OfRing(_0xdd5fbbc8), 0.26f);
            if (!_0x99e3dac5)
            {
                this._halo.DOFade(0.44f, 1.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._halo.gameObject);
            }
        }
    }

    private _0x5afdf70c _0xc71bd4ab;
    [SerializeField]
    private Image _halo;
    public float _0x41cf06ef
    {
        get
        {
            return this._rect == null ? 0f : this._rect.anchoredPosition.x;
        }
    }
}