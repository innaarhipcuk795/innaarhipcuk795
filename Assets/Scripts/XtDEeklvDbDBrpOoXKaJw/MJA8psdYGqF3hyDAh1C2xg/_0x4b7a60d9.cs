using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x4b7a60d9 : MonoBehaviour
{
    private List<string> _0x98686514 = new();
    private void Update()
    {
        int _0x13ed4952 = 1;
        if (this._0x98686514.Count > 0)
        {
            string _0xe0d2f63a = this._0x6a822208.text;
            foreach (string _0x18c52f3d in this._0x98686514)
                while (_0xe0d2f63a.Contains(_0x18c52f3d))
                    _0xe0d2f63a = _0xe0d2f63a.Replace(_0x18c52f3d, "");
            _0x13ed4952 = _0xe0d2f63a.Length;
        }
        else
        {
            _0x13ed4952 = this._0x6a822208.text.Length;
        }

        float _0xf0655f83 = Mathf.Clamp(this._0x79679003 + this._0xf5fec7c9 * _0x13ed4952, this._0x71484938, this._0x9c1215d1);
        if (!Mathf.Approximately(this._0xd22f78df.aspectRatio, _0xf0655f83))
            this._0xd22f78df.aspectRatio = _0xf0655f83;
    }

    private float _0x9c1215d1 = 4;
    private AspectRatioFitter _0xd22f78df;
    private float _0x71484938 = 1.5f;
    private TMP_Text _0x6a822208;
    private float _0x79679003;
    private float _0xf5fec7c9 = 0.6f;
}