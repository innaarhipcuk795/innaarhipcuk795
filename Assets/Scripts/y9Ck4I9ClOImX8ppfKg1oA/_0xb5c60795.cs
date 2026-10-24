using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>A storm shard drifting down the edge of the lane. The contact test is pure
/// arithmetic on floats - this game drives no bodies and uses no engine collision.</summary>
public sealed class _0xb5c60795 : MonoBehaviour
{
    public void _0x7782d9d3()
    {
        if (this._0xd83a7277)
        {
            return;
        }

        this._0xd83a7277 = true;
        if (this._crystal != null)
        {
            this._crystal.DOFade(0f, 0.22f).SetLink(this._crystal.gameObject);
        }
    }

    public bool _0x889b412d
    {
        get
        {
            return this._0xd83a7277;
        }
    }

    [SerializeField]
    private RectTransform _rect;
    private bool _0xd83a7277;
    public void _0x4d33cf2e(_0xadc65cb2 _0xbaad23a0, float _0x6c8a168c, bool _0x232380d1)
    {
        this._0xd83a7277 = false;
        if (this._rect != null)
        {
            this._rect.anchoredPosition = new Vector2(_0x6c8a168c, 0f);
            this._rect.sizeDelta = _0x531552b7.Square(_0x531552b7.ShardD);
            this._rect.localScale = Vector3.one;
        }

        if (this._crystal != null)
        {
            this._crystal.sprite = _0xbaad23a0.Shard;
            this._crystal.color = Color.white;
            if (!_0x232380d1)
            {
                this._crystal.rectTransform.DOLocalRotate(new Vector3(0f, 0f, 14f), 1.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._crystal.gameObject);
            }
        }
    }

    private void OnDestroy()
    {
        DOTween.Kill(this._rect);
        DOTween.Kill(this._crystal);
    }

    [SerializeField]
    private Image _crystal;
    public float _0xe8ee0e72
    {
        get
        {
            return this._rect == null ? 0f : this._rect.anchoredPosition.x;
        }
    }
}