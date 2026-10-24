using UnityEngine;
using UnityEngine.UI;

public class _0xfff0d341 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x17c8dcf5.Instance._0x913e141d();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x17c8dcf5.Instance._0xb450d753());
        else
            this.Button.onClick.AddListener(() => _0x17c8dcf5.Instance._0xb2f8fd68(this.PopToShowIndex));
    }

    public bool IsHideAllPops;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    public bool IsShowLastPop;
    public int PopToShowIndex;
}