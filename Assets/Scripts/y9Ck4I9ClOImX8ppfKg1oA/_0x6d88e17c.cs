using UnityEngine;

/// <summary>
/// One gate in flight: its rings, its shard, and the arithmetic that decides what the
/// dragon did when the gate's plane crossed it. No engine collision anywhere.
/// </summary>
public sealed class _0x6d88e17c : MonoBehaviour
{
    private RectTransform _0x9d97d356;
    public void _0x4abddc29()
    {
        this._0x42dce299 = true;
    }

    public void _0xa02e30f3(float _0xce2c3107)
    {
        if (this._0x9d97d356 == null)
        {
            return;
        }

        Vector2 _0x1c88125f = this._0x9d97d356.anchoredPosition;
        this._0x9d97d356.anchoredPosition = new Vector2(_0x1c88125f.x, _0x1c88125f.y - _0xce2c3107);
    }

    public int _0x90149bab
    {
        get
        {
            return this._0x4381d468;
        }
    }

    private bool _0x42dce299;
    public void _0xbaa347af()
    {
        if (this._0x9d370c8e != null)
        {
            this._0x9d370c8e._0x7782d9d3();
        }
    }

    private _0xb5c60795 _0x9d370c8e;
    public void _0xc67eaba1(RectTransform _0xf6ff88a5, _0xadc65cb2 _0x5b6213c5, _0x262b3467 _0x33d5052b, int _0x876cde7e, _0x78f632c2 _0xc36cc838, _0xb5c60795 _0xeccb5d43, bool _0x4b306db4)
    {
        this._0x4381d468 = _0x876cde7e;
        this._0x42dce299 = false;
        this._0x9d97d356 = this.gameObject.GetComponent<RectTransform>();
        if (this._0x9d97d356 == null)
        {
            this._0x9d97d356 = this.gameObject.AddComponent<RectTransform>();
        }

        this._0x9d97d356.SetParent(_0xf6ff88a5, false);
        this._0x9d97d356.anchorMin = Vector2.zero;
        this._0x9d97d356.anchorMax = Vector2.zero;
        this._0x9d97d356.pivot = new Vector2(0.5f, 0.5f);
        this._0x9d97d356.sizeDelta = new Vector2(_0x531552b7.PanelW, _0x531552b7.RingOuter);
        this._0x9d97d356.anchoredPosition = new Vector2(_0x531552b7.PanelCx, _0x531552b7.SpawnY);
        this._0x9d97d356.localScale = Vector3.one;
        if (_0x33d5052b.HasShard && _0xeccb5d43 != null)
        {
            this._0x9d370c8e = Instantiate(_0xeccb5d43, this._0x9d97d356, false);
            this._0x9d370c8e._0x4d33cf2e(_0x5b6213c5, _0x33d5052b.ShardX, _0x4b306db4);
        }

        if (_0xc36cc838 != null)
        {
            this._0x86912786 = Instantiate(_0xc36cc838, this._0x9d97d356, false);
            this._0x86912786._0x6d40ca52(_0x5b6213c5, _0x33d5052b.RingAColour, _0x33d5052b.RingAx, _0x4b306db4);
            if (_0x33d5052b.HasSecondRing)
            {
                this._0x969987c4 = Instantiate(_0xc36cc838, this._0x9d97d356, false);
                this._0x969987c4._0x6d40ca52(_0x5b6213c5, _0x33d5052b.RingBColour, _0x33d5052b.RingBx, _0x4b306db4);
            }
        }
    }

    public float _0x546c44ba
    {
        get
        {
            return this._0x9d97d356 == null ? 0f : this._0x9d97d356.anchoredPosition.y;
        }
    }

    private _0x78f632c2 _0x86912786;
    /// <summary>
    /// Arithmetic contact test on both axes. The y test is what makes it a contact rather
    /// than a column: without it a shard still high up the screen would register the
    /// moment the dragon drifted under its x.
    /// </summary>
    public bool _0x8788df96(float _0xb303b4e1)
    {
        if (this._0x9d370c8e == null || this._0x9d370c8e._0x889b412d)
        {
            return false;
        }

        float _0x4c293c51 = (_0x531552b7.DragonH * 0.5f) + (_0x531552b7.ShardD * 0.5f);
        if (Mathf.Abs(this._0x546c44ba - _0x531552b7.DragonY) > _0x4c293c51)
        {
            return false;
        }

        float _0x0834baa4 = _0x531552b7.DragonHalfW + (_0x531552b7.ShardD * 0.5f);
        return Mathf.Abs(_0xb303b4e1 - this._0x9d370c8e._0xe8ee0e72) <= _0x0834baa4;
    }

    private int _0x4381d468;
    /// <summary>The ring the dragon threaded, or null for a miss.</summary>
    public _0x78f632c2 _0x537e8564(float _0x39f067a7)
    {
        if (this._0x86912786 != null && Mathf.Abs(_0x39f067a7 - this._0x86912786._0x41cf06ef) <= _0x531552b7.RingInnerR)
        {
            return this._0x86912786;
        }

        if (this._0x969987c4 != null && Mathf.Abs(_0x39f067a7 - this._0x969987c4._0x41cf06ef) <= _0x531552b7.RingInnerR)
        {
            return this._0x969987c4;
        }

        return null;
    }

    private _0x78f632c2 _0x969987c4;
    public void _0xde1bc712(float _0xd2086924)
    {
        if (this._0x9d97d356 == null)
        {
            return;
        }

        this._0x9d97d356.anchoredPosition = new Vector2(_0x531552b7.PanelCx, _0xd2086924);
    }

    public bool _0x9f824837
    {
        get
        {
            return this._0x42dce299;
        }
    }

    /// <summary>The nearest ring of this gate carrying the given charge, for the guide beam.</summary>
    public _0x78f632c2 _0x5853dbd5(_0x5afdf70c _0xc1206d5b)
    {
        if (this._0x86912786 != null && this._0x86912786._0xf120a0da == _0xc1206d5b)
        {
            return this._0x86912786;
        }

        if (this._0x969987c4 != null && this._0x969987c4._0xf120a0da == _0xc1206d5b)
        {
            return this._0x969987c4;
        }

        return this._0x86912786;
    }
}