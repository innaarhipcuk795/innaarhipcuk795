using UnityEngine;
using UnityEngine.UI;

public class _0x1fcda8f8 : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x2bc80d8c.Instance._0x99ca33d7(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
}