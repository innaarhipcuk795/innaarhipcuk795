using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xdc3d08c2 : MonoBehaviour
{
    private Image _0x4f7a416b;
    private void _0xdeac5cb8()
    {
        if (this._0x4f7a416b.canvasRenderer.GetColor() != this._0xb1e9032b.canvasRenderer.GetColor())
            this._0xb1e9032b.canvasRenderer.SetColor(this._0x4f7a416b.canvasRenderer.GetColor());
    }

    private void Update()
    {
        this._0xdeac5cb8();
    }

    private TMP_Text _0xb1e9032b;
}