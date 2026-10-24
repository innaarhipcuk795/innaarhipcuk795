using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A scrolling sky layer, built as two stacked tiles of seeded motes that recycle by y.
/// Two of these (a far star field and a near cloud drift) give the depth the flat
/// background cannot.
/// </summary>
public sealed class _0x74f82676 : MonoBehaviour
{
    private RectTransform _0x05963a92;
    public void _0x6c6449b3(float _0x5eb9d3ad)
    {
        this._0xdc04b968(this._0x7a87cf71, _0x5eb9d3ad * this._0x5c8653a7);
        this._0xdc04b968(this._0x05963a92, _0x5eb9d3ad * this._0x5c8653a7);
    }

    public void _0x9a36b090(RectTransform _0x39c7bcec, _0xadc65cb2 _0x1af83f75, Image _0x297df41b, int _0x92ced38c, int _0x799e4a65, float _0x1c0119c3, float _0xe7db35b9, float _0x2b83a988, Color _0xcca403a1)
    {
        this._0x5c8653a7 = _0x1c0119c3;
        this._0x7a87cf71 = _0x29ecbd6a.Node(_0x39c7bcec, _0xf7dc681a._0xe2bd1464(new byte[7] { 125, 69, 87, 122, 71, 66, 75 }, 46), new Vector2(_0x531552b7.PanelCx, _0x531552b7.PanelH * 0.5f), new Vector2(_0x531552b7.PanelW, _0x531552b7.PanelH));
        this._0x05963a92 = _0x29ecbd6a.Node(_0x39c7bcec, _0xf7dc681a._0xe2bd1464(new byte[7] { 63, 7, 21, 56, 5, 0, 9 }, 108), new Vector2(_0x531552b7.PanelCx, _0x531552b7.PanelH * 1.5f), new Vector2(_0x531552b7.PanelW, _0x531552b7.PanelH));
        System.Random _0xec6ce949 = new System.Random(_0x92ced38c);
        this._0xf2a0f63c(this._0x7a87cf71, _0x1af83f75, _0x297df41b, _0xec6ce949, _0x799e4a65, _0xe7db35b9, _0x2b83a988, _0xcca403a1);
        this._0xf2a0f63c(this._0x05963a92, _0x1af83f75, _0x297df41b, _0xec6ce949, _0x799e4a65, _0xe7db35b9, _0x2b83a988, _0xcca403a1);
    }

    private RectTransform _0x7a87cf71;
    private float _0x5c8653a7;
    private void _0xf2a0f63c(RectTransform _0x8953cc41, _0xadc65cb2 _0xd2fd92e3, Image _0x66808852, System.Random _0x08e1922f, int _0x286081fa, float _0x1d854fa7, float _0xf0327ee9, Color _0xdced9e25)
    {
        for (int _0x995a665f = 0; _0x995a665f < _0x286081fa; _0x995a665f++)
        {
            Image _0x1884998a = Instantiate(_0x66808852, _0x8953cc41, false);
            _0x1884998a.sprite = _0xd2fd92e3.Spark;
            _0x1884998a.preserveAspect = true;
            _0x1884998a.raycastTarget = false;
            float _0x7fb38a1f = Mathf.Lerp(_0x1d854fa7, _0xf0327ee9, (float)_0x08e1922f.NextDouble());
            RectTransform _0x56c5ebad = _0x1884998a.rectTransform;
            _0x56c5ebad.anchorMin = Vector2.zero;
            _0x56c5ebad.anchorMax = Vector2.zero;
            _0x56c5ebad.pivot = new Vector2(0.5f, 0.5f);
            _0x56c5ebad.sizeDelta = _0x531552b7.Square(_0x7fb38a1f);
            _0x56c5ebad.anchoredPosition = new Vector2((float)_0x08e1922f.NextDouble() * _0x531552b7.PanelW, (float)_0x08e1922f.NextDouble() * _0x531552b7.PanelH);
            _0x1884998a.color = _0x2ac8856b.Faded(_0xdced9e25, Mathf.Lerp(0.25f, 0.8f, (float)_0x08e1922f.NextDouble()));
        }
    }

    private void _0xdc04b968(RectTransform _0x20fa4ab0, float _0x8376ed07)
    {
        if (_0x20fa4ab0 == null)
        {
            return;
        }

        Vector2 _0xd27582ac = _0x20fa4ab0.anchoredPosition;
        float _0x570b40e7 = _0xd27582ac.y - _0x8376ed07;
        if (_0x570b40e7 < -_0x531552b7.PanelH * 0.5f)
        {
            _0x570b40e7 += _0x531552b7.PanelH * 2f;
        }

        _0x20fa4ab0.anchoredPosition = new Vector2(_0xd27582ac.x, _0x570b40e7);
    }
}

internal static class _0xf7dc681a
{
    internal static string _0xe2bd1464(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}