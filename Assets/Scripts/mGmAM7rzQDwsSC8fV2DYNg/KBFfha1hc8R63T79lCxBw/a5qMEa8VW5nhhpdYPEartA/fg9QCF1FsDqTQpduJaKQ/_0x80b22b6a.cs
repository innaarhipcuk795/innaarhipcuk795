using TMPro;
using UnityEngine;
using static _0x014c750c;

public class _0x80b22b6a : MonoBehaviour
{
    public void _0x90ae0bef()
    {
        this.MoneyCountText.text = _0x197748fa._0x43e96ed6.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xc74a4e34;
            if (this.gameObject.TryGetComponent(out _0xc74a4e34))
                this.MoneyCountText = _0xc74a4e34;
        }

        this._0x90ae0bef();
    }

    public TMP_Text MoneyCountText;
}