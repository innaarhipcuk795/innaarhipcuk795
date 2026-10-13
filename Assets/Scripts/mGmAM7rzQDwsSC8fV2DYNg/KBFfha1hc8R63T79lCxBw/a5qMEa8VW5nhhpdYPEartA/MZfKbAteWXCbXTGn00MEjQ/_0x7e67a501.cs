using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x7e67a501 : MonoBehaviour
{
    public static void HideAllPops()
    {
        _0x17c8dcf5.Instance._0xb450d753();
    }

    public GameObject Content;
    public TMP_Text ContentAdditionalText;
    private void _0xfb8862cc()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public Image ContentImage;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    private void Start()
    {
    // Content.SetActive(false);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xfb8862cc();
    }

    public bool IsOnlyYScale;
    public void _0xbb0c5a2c()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private bool _0xeadbaaa2 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text ContentHeaderText;
    public float scaleDuration = 0.4f;
    public bool IsScaledDownOnAwake = true;
    public Ease ease = Ease.OutSine;
    public TMP_Text ContentMainText;
}