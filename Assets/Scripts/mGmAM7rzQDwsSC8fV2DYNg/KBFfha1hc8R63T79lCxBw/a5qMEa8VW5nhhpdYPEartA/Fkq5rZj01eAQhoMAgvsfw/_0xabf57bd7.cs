using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xabf57bd7 : MonoBehaviour
{
    public float ScaleDuration = 0.4f;
    public void Show()
    {
        this._0xb0477f6c();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x84e527ab.Instance._0x382a6157(_0x84e527ab.Instance.CurrentPanelIndex);
            });
        }
    }

    public GameObject Content;
    public TMP_Text MainText;
    private void _0xd4daa7f6()
    {
        if (this.OuterBackground != null)
        {
            Image _0x7f7dfa06 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x7f7dfa06, true);
            _0x7f7dfa06.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public Ease Ease = Ease.OutSine;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xd4daa7f6();
    }

    public bool IsScaledDownOnAwake = true;
    private bool _0x232a0470 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text HeaderText;
    public GameObject OuterBackground;
    public void _0x421bd8aa()
    {
        this._0xc5115aca();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x84e527ab.Instance._0x382a6157(_0x84e527ab.Instance.CurrentPanelIndex);
    }

    public void _0x55f466f6()
    {
        this._0xadba0025();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0xb0477f6c()
    {
        if (this.OuterBackground != null)
        {
            Image _0x541820a7 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x541820a7, true);
            _0x541820a7.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0xadba0025()
    {
        if (this.OuterBackground != null)
        {
            Image _0xfc9c4fdd = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xfc9c4fdd, true);
            _0xfc9c4fdd.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0xc5115aca()
    {
        if (this.OuterBackground != null)
        {
            Image _0x26f9797c = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x26f9797c, true);
            _0x26f9797c.DOFade(1f, 0f);
        }
    }
}