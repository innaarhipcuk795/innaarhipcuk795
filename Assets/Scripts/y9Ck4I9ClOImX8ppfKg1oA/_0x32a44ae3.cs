using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// The run: the course scrolls, the dragon banks, a gate resolves by one arithmetic test
/// when its plane crosses the dragon. The scroll is integrated in Update with a clamped
/// delta (never a tween), so a frame hitch cannot teleport a gate past the dragon.
///
/// Balance (C.5): aether only ever drains on a MISS, the generator guarantees at least
/// 55% reachable gates and never three hard ones in a row, so a run with no input at all
/// reaches the end of the course - roughly 80 seconds, about fifty past the last frame the
/// review capture takes.
/// </summary>
public sealed class _0x32a44ae3 : MonoBehaviour
{
    private void _0x203fb75c()
    {
        if (this._0x888aa041 == _0x968f1203.Settling || this._0x888aa041 == _0x968f1203.Ended)
        {
            return;
        }

        this._0x888aa041 = _0x968f1203.Settling;
        this._0x0df0108f = 0f;
        this._0x0b8a848d._0xd531bf33(false, 0f, 0f, 0f);
    }

    private float _0x173498f5;
    private void _0x1569b674(_0x6d88e17c _0xf3acb9b6, float _0xc32af3ae)
    {
        this._0x1c5c8a58++;
        _0x78f632c2 _0x333dcfa9 = _0xf3acb9b6._0x537e8564(_0xc32af3ae);
        if (_0x333dcfa9 == null)
        {
            this._0xa91c63c7 = 0;
            this._0x69ddfc6e += _0x531552b7.AetherOnMiss;
        }
        else
        {
            bool _0x5a271af1 = _0x333dcfa9._0xf120a0da == this._0x7e448a90;
            float _0x3f22729d = _0x5a271af1 ? Mathf.Min(1f + (_0x531552b7.ChainStep * this._0xa91c63c7), _0x531552b7.ChainCap) : 1f;
            this._0x5f283ea1 += Mathf.RoundToInt(_0x531552b7.ScoreOnPass * _0x3f22729d);
            this._0xf9dbbfcd++;
            if (_0x5a271af1)
            {
                this._0xa91c63c7++;
                if (this._0xa91c63c7 > this._0x0ea97974)
                {
                    this._0x0ea97974 = this._0xa91c63c7;
                }

                this._0x69ddfc6e += _0x531552b7.AetherOnMatch;
            }
            else
            {
                this._0xa91c63c7 = 0;
                this._0x69ddfc6e += _0x531552b7.AetherOnPass;
            }

            this._0x7e448a90 = _0x333dcfa9._0xf120a0da;
            _0x333dcfa9._0xf6337831(1f);
            this._0x0b8a848d._0x8648fac9._0x61327a2f(this._0x7e448a90);
            this._0x0b8a848d._0x78a70968._0xced1fb8d(this._0x7e448a90);
        }

        this._0x69ddfc6e = Mathf.Clamp(this._0x69ddfc6e, 0f, _0x531552b7.AetherMax);
        this._0x0b8a848d._0x78a70968._0x4983aa07(this._0x5f283ea1);
        this._0x0b8a848d._0x78a70968._0xf681b087(this._0x69ddfc6e, _0x531552b7.AetherMax);
        this._0x0b8a848d._0x78a70968._0xd3ad64d3(this._0xa91c63c7, Mathf.Min(1f + (_0x531552b7.ChainStep * this._0xa91c63c7), _0x531552b7.ChainCap));
        this._0x0b8a848d._0x78a70968._0x7915fbf6(Mathf.Min(this._0x1c5c8a58 + 1, this._0xdf2b4548.Gates.Length), this._0xdf2b4548.Gates.Length);
    }

    public void _0x024b0d5f(_0x10aa417e _0xad9f1625, _0xadc65cb2 _0x4d0e7be1, _0x78f632c2 _0xac7e0672, _0xb5c60795 _0xe0f3208f, _0x07ce4a95 _0x7540b7ce, _0x16a559e2 _0xdc4cbe5d, _0xf6a1b425 _0xfead118e, int _0x11ba08ee)
    {
        this._0x0b8a848d = _0xad9f1625;
        this._0x045d6575 = _0x4d0e7be1;
        this._0x7055d2ca = _0xac7e0672;
        this._0xb73248d1 = _0xe0f3208f;
        this._0x8fe172da = _0x7540b7ce;
        this._0x74180ca4 = _0xdc4cbe5d;
        this._0x404a61ce = _0x11ba08ee;
        this._0x2bf0f678 = _0xdc4cbe5d._0xb36b7342();
        this._0x7af50ab4 = _0xdc4cbe5d._0x53f9335d();
        int _0x0bfc170c = _0xdc4cbe5d._0x95091cb1();
        int _0x939ec40a = (_0x11ba08ee * 7919) ^ (_0x0bfc170c * 104729);
        _0x1aeca002 _0x5bddf38f = new _0x1aeca002();
        this._0xdf2b4548 = _0x5bddf38f._0x89a3ad95(_0xfead118e, _0x939ec40a);
        this._0xb484ad39 = _0xfead118e._0x5a69b43e();
        this._0x69ddfc6e = _0x531552b7.AetherMax;
        this._0x173498f5 = 0f;
        this._0x888aa041 = _0x968f1203.Intro;
        this._0x0df0108f = 0f;
        this._0x0b8a848d._0x35989b07(_0x531552b7.IntroSeconds);
        this._0x0b8a848d._0x78a70968._0x7915fbf6(1, this._0xdf2b4548.Gates.Length);
        this._0x0b8a848d._0x78a70968._0x4983aa07(0);
        this._0x0b8a848d._0x78a70968._0xf681b087(this._0x69ddfc6e, _0x531552b7.AetherMax);
        this._0x0b8a848d._0x78a70968._0xced1fb8d(this._0x7e448a90);
        this._0x0b8a848d._0x78a70968._0xd3ad64d3(0, 1f);
        this._0x0b8a848d._0x78a70968._0x25215d56(this._0x2bf0f678);
        this._0x0b8a848d._0x8648fac9._0x61327a2f(this._0x7e448a90);
        this._0x0c34715a();
    }

    private _0x07ce4a95 _0x8fe172da;
    private int _0xf9dbbfcd;
    private int _0x404a61ce;
    private _0xe9121302 _0xdf2b4548;
    private void OnDestroy()
    {
        DOTween.Kill(this);
    }

    private void Update()
    {
        if (this._0x888aa041 == _0x968f1203.Ended)
        {
            return;
        }

        if (_0x2bc80d8c.Instance == null || !_0x2bc80d8c.Instance._0x41e1785e)
        {
            return;
        }

        float delta = Mathf.Min(Time.deltaTime, _0x531552b7.MaxDelta);
        this._0x0df0108f += delta;
        if (this._0x888aa041 == _0x968f1203.Intro)
        {
            this._0x0b8a848d._0x6c9b525c(this._0xb484ad39 * delta * 0.5f);
            if (this._0x0df0108f >= _0x531552b7.IntroSeconds)
            {
                this._0x888aa041 = _0x968f1203.Flying;
                this._0x0df0108f = 0f;
            }

            return;
        }

        if (this._0x888aa041 == _0x968f1203.Settling)
        {
            float _0x906a8271 = Mathf.Clamp01(1f - (this._0x0df0108f / _0x531552b7.OutroSeconds));
            this._0xabdf3876(delta * _0x906a8271);
            this._0x0b8a848d._0x8648fac9._0x37586d77(delta, false);
            if (this._0x0df0108f >= _0x531552b7.OutroSeconds)
            {
                this._0xcd98cccf();
            }

            return;
        }

        float _0x78d725a6 = this._0x0b8a848d._0x8648fac9._0x37586d77(delta, true);
        this._0xabdf3876(delta);
        this._0xcd46e6a0(_0x78d725a6);
        this._0x7726f267(_0x78d725a6);
    }

    private int _0x0ea97974;
    private _0xb5c60795 _0xb73248d1;
    private void _0x7726f267(float _0x52f2e31a)
    {
        if (!this._0x7af50ab4)
        {
            this._0x0b8a848d._0xd531bf33(false, 0f, 0f, 0f);
            return;
        }

        _0x6d88e17c _0x3b1a0dfc = null;
        for (int _0xea09b2fb = 0; _0xea09b2fb < this._0x0cb01f19.Count; _0xea09b2fb++)
        {
            _0x6d88e17c _0x3d1f7e3c = this._0x0cb01f19[_0xea09b2fb];
            if (_0x3d1f7e3c._0x9f824837 || _0x3d1f7e3c._0x546c44ba <= _0x531552b7.DragonY)
            {
                continue;
            }

            if (_0x3b1a0dfc == null || _0x3d1f7e3c._0x546c44ba < _0x3b1a0dfc._0x546c44ba)
            {
                _0x3b1a0dfc = _0x3d1f7e3c;
            }
        }

        if (_0x3b1a0dfc == null)
        {
            this._0x0b8a848d._0xd531bf33(false, 0f, 0f, 0f);
            return;
        }

        _0x78f632c2 _0xe4b847da = _0x3b1a0dfc._0x5853dbd5(this._0x7e448a90);
        float _0x8286b872 = _0xe4b847da == null ? 0f : _0xe4b847da._0x41cf06ef;
        this._0x0b8a848d._0xd531bf33(true, _0x52f2e31a, _0x8286b872, _0x3b1a0dfc._0x546c44ba);
    }

    private enum _0x968f1203
    {
        Intro = 0,
        Flying = 1,
        Settling = 2,
        Ended = 3
    }

    private bool _0x7af50ab4;
    private _0x968f1203 _0x888aa041 = _0x968f1203.Intro;
    /// <summary>Raised by the pause button; the template's own resume driver undoes it.</summary>
    public void _0xf2e6bbfb()
    {
        this._0x8fe172da._0xb315c8d2(this._0x1c5c8a58 + 1, this._0xdf2b4548.Gates.Length, Mathf.Min(1f + (_0x531552b7.ChainStep * this._0xa91c63c7), _0x531552b7.ChainCap), Mathf.RoundToInt((this._0x69ddfc6e / _0x531552b7.AetherMax) * 100f));
    }

    private float _0x0df0108f;
    private void _0xabdf3876(float delta)
    {
        float amount = this._0xb484ad39 * delta;
        this._0x0b8a848d._0x6c9b525c(amount);
        this._0x173498f5 += amount;
        for (int _0xd611db7b = 0; _0xd611db7b < this._0x0cb01f19.Count; _0xd611db7b++)
        {
            this._0x0cb01f19[_0xd611db7b]._0xa02e30f3(amount);
        }

        this._0x0c34715a();
    }

    private float _0xb484ad39;
    private _0xadc65cb2 _0x045d6575;
    private _0x10aa417e _0x0b8a848d;
    private bool _0x2bf0f678;
    private void _0xcd98cccf()
    {
        this._0x888aa041 = _0x968f1203.Ended;
        bool _0x2d75c110 = this._0x1c5c8a58 >= this._0xdf2b4548.Gates.Length && this._0x69ddfc6e > 0f;
        int _0x50b333a4 = this._0x5f283ea1 + (_0x2d75c110 ? _0x531552b7.ScorePerGateBonus * this._0xdf2b4548.Gates.Length : 0);
        int _0x08604da0 = _0x50b333a4 / _0x531552b7.ShardsPerScore;
        float _0x985f7085 = Mathf.Min(1f + (_0x531552b7.ChainStep * this._0x0ea97974), _0x531552b7.ChainCap);
        this._0x74180ca4._0x1b642f71(this._0x404a61ce, _0x50b333a4);
        _0x014c750c._0x197748fa._0x43e96ed6 = _0x014c750c._0x197748fa._0x43e96ed6 + _0x08604da0;
        if (_0x2d75c110)
        {
            // The NEXT COURSE button on the win pop reloads this scene, so the course the
            // run advances to is stored BEFORE the pop is raised.
            this._0x74180ca4._0xed1aa910(Mathf.Min(this._0x404a61ce + 1, _0x16a559e2.CourseCount - 1));
            this._0x8fe172da._0xb5a55daa(_0x50b333a4, this._0xf9dbbfcd, this._0xdf2b4548.Gates.Length, _0x985f7085, _0x08604da0);
        }
        else
        {
            this._0x8fe172da._0x92d57583(_0x50b333a4, this._0x1c5c8a58, this._0xdf2b4548.Gates.Length, _0x985f7085, _0x08604da0);
        }
    }

    private float _0x69ddfc6e;
    /// <summary>
    /// Gate i rides at SpawnY + i * GateSpacing and the whole course scrolls as one, so a
    /// gate is created exactly when that line reaches the top of the panel.
    /// </summary>
    private void _0x0c34715a()
    {
        while (this._0x608bc706 < this._0xdf2b4548.Gates.Length)
        {
            float _0x2978e62a = _0x531552b7.SpawnY + (this._0x608bc706 * _0x531552b7.GateSpacing) - this._0x173498f5;
            if (_0x2978e62a > _0x531552b7.SpawnY)
            {
                return;
            }

            GameObject _0x10980d84 = new GameObject(_0x42bdcc01._0xfd9b9a2f(new byte[4] { 140, 170, 191, 174 }, 203), typeof(RectTransform));
            _0x6d88e17c _0x9cb6102b = _0x10980d84.AddComponent<_0x6d88e17c>();
            _0x9cb6102b._0xc67eaba1(this._0x0b8a848d._0x8b089aad, this._0x045d6575, this._0xdf2b4548.Gates[this._0x608bc706], this._0x608bc706, this._0x7055d2ca, this._0xb73248d1, this._0x2bf0f678);
            _0x9cb6102b._0xde1bc712(_0x2978e62a);
            this._0x0cb01f19.Add(_0x9cb6102b);
            this._0x608bc706++;
        }
    }

    private int _0x1c5c8a58;
    private int _0xa91c63c7;
    private _0x5afdf70c _0x7e448a90 = _0x5afdf70c.Azure;
    private readonly List<_0x6d88e17c> _0x0cb01f19 = new List<_0x6d88e17c>();
    private _0x16a559e2 _0x74180ca4;
    private int _0x608bc706;
    private _0x78f632c2 _0x7055d2ca;
    private void _0xcd46e6a0(float _0x7de92e91)
    {
        for (int _0xd0a8b84b = this._0x0cb01f19.Count - 1; _0xd0a8b84b >= 0; _0xd0a8b84b--)
        {
            _0x6d88e17c _0xe845083c = this._0x0cb01f19[_0xd0a8b84b];
            if (!_0xe845083c._0x9f824837 && _0xe845083c._0x8788df96(_0x7de92e91))
            {
                _0xe845083c._0xbaa347af();
                this._0x5f283ea1 = Mathf.Max(this._0x5f283ea1 + _0x531552b7.ScoreOnShard, 0);
                this._0x69ddfc6e += _0x531552b7.AetherOnShard;
                this._0xa91c63c7 = 0;
                this._0x0b8a848d._0x6928b86a();
                this._0x0b8a848d._0x8648fac9._0xe20b9592();
                this._0x0b8a848d._0x78a70968._0x4983aa07(this._0x5f283ea1);
                this._0x0b8a848d._0x78a70968._0xd3ad64d3(this._0xa91c63c7, 1f);
            }

            if (!_0xe845083c._0x9f824837 && _0xe845083c._0x546c44ba <= _0x531552b7.DragonY)
            {
                _0xe845083c._0x4abddc29();
                this._0x1569b674(_0xe845083c, _0x7de92e91);
            }

            if (_0xe845083c._0x546c44ba < _0x531552b7.DespawnY)
            {
                this._0x0cb01f19.RemoveAt(_0xd0a8b84b);
                Destroy(_0xe845083c.gameObject);
            }
        }

        if (this._0x69ddfc6e <= 0f)
        {
            this._0x69ddfc6e = 0f;
            this._0x0b8a848d._0x78a70968._0xf681b087(this._0x69ddfc6e, _0x531552b7.AetherMax);
            this._0x203fb75c();
            return;
        }

        if (this._0x1c5c8a58 >= this._0xdf2b4548.Gates.Length)
        {
            this._0x203fb75c();
        }
    }

    private int _0x5f283ea1;
}

internal static class _0x42bdcc01
{
    internal static string _0xfd9b9a2f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}