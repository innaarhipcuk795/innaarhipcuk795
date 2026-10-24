using UnityEngine;
using UnityEngine.UI;

public class _0x770642f0 : MonoBehaviour
{
    private int _0x023d1456;
    private void Start()
    {
        if (this._0x09bc7c44)
            this._0xfd325360.onClick.AddListener(() => _0x84e527ab.Instance._0x55cb0024());
        else
            this._0xfd325360.onClick.AddListener(() => _0x84e527ab.Instance._0x24f58fbd(this._0x023d1456));
    }

    private void Awake()
    {
        if (this._0xfd325360 == null)
            if (!this.TryGetComponent(out this._0xfd325360))
                this._0xfd325360 = this.GetComponentInChildren<Button>();
    }

    private bool _0x09bc7c44;
    private Button _0xfd325360;
}