using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xe6b3ba0e : MonoBehaviour
{
    public float FirstAnimationTime = 10.0f;
    public GameObject Error;
    private void _0xb4e68f06()
    {
        this.AnimationSlider.value = 0.05f;
        _0x30e25359 = !_0x30e25359;
        this._0xbe0931b7 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xb572618e => this.AnimationSlider.value = _0xb572618e, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x7c55b980._0x9ab4bb01?._0xf3c2f44d();
        });
    }

    public void _0xdb66c152()
    {
        this._0x1adf167c();
        bool _0x7cdd2a94 = _0x30e25359;
        this._0xbe0931b7 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xb572618e => this.AnimationSlider.value = _0xb572618e, _0x7cdd2a94 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x30e25359 = !_0x30e25359;
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xe6b3ba0e>();
    }

    public void _0xb3585b51()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xbe0931b7?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x30e25359 = false;
    }

    public float DefaultAnimationTime = 0.4f;
    public void _0x24aed336()
    {
        this._0xbe0931b7?.Play();
    }

    public GameObject Content;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x014c750c._0x99049008.SCENE_0 && !_0x30e25359)
        {
            this._0xb4e68f06();
        }
        else
        {
            this._0xdb66c152();
        }
    }

    private static bool _0x30e25359 = false;
    private Sequence _0xbe0931b7;
    public static _0xe6b3ba0e Instance;
    public float SecondPassSliderValue = 0.5f;
    public GameObject Background;
    public Slider AnimationSlider;
    public void _0x1adf167c()
    {
        this._0xbe0931b7?.Kill();
        this.AnimationSlider.value = _0x30e25359 ? this.SecondPassSliderValue : 0.05f;
    }

    public void _0xea3929fb()
    {
        this._0xbe0931b7?.Pause();
    }
}