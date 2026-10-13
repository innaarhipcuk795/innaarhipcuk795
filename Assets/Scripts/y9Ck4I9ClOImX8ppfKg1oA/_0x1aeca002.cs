using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Builds a course CONSTRUCTIVELY (C.11): the invariants hold because of how the layout is
/// assembled, never because a rejected roll was tried again. A layout that cannot
/// physically satisfy the spacing rule burns every retry, so there is no retry loop here.
///
/// The three invariants, all asserted before the layout is handed out:
///   1. at least ceil(gates * driftRatio) gates carry a ring inside the pass radius of a
///      dragon sitting at x = 0;
///   2. never more than two consecutive gates without one;
///   3. every shard sits at |x| >= ShardMinX, clear of a dragon that never steers.
/// Together they are the proof behind C.5: a run with zero input always reaches the end.
/// </summary>
public sealed class _0x1aeca002
{
    /// <summary>
    /// Colours follow the chain the ideal player would carry, so a choice gate really is a
    /// decision: exactly one of its two rings matches the charge arriving there.
    /// Four identical colours in a row are forbidden, so the course never reads as flat.
    /// </summary>
    private void _0x6730001e(_0x262b3467[] _0x9eaae60d, System.Random _0x41c01c3b)
    {
        _0x5afdf70c _0xa39f8360 = _0x5afdf70c.Azure;
        _0x5afdf70c _0xfadcd530 = _0x5afdf70c.Azure;
        int _0xfadce0a2 = 0;
        for (int _0xb17e5373 = 0; _0xb17e5373 < _0x9eaae60d.Length; _0xb17e5373++)
        {
            _0x262b3467 _0xe1f70bdf = _0x9eaae60d[_0xb17e5373];
            _0x5afdf70c _0x145e1d99 = this._0xc596f6ad(_0x41c01c3b, _0xfadcd530, _0xfadce0a2);
            if (_0xe1f70bdf.HasSecondRing)
            {
                bool _0x75a17174 = _0x41c01c3b.Next(0, 2) == 0;
                _0x5afdf70c _0x20d15356 = this._0x89b6fe3a(_0x41c01c3b, _0xa39f8360);
                _0xe1f70bdf.RingAColour = _0x75a17174 ? _0xa39f8360 : _0x20d15356;
                _0xe1f70bdf.RingBColour = _0x75a17174 ? _0x20d15356 : _0xa39f8360;
                _0x145e1d99 = _0xa39f8360;
            }
            else
            {
                _0xe1f70bdf.RingAColour = _0x145e1d99;
            }

            _0xfadce0a2 = _0x145e1d99 == _0xfadcd530 ? _0xfadce0a2 + 1 : 0;
            _0xfadcd530 = _0x145e1d99;
            _0xa39f8360 = _0x145e1d99;
        }
    }

    private const int MaxConsecutiveHard = 2;
    /// <summary>
    /// Shards drift in from gate 7 onward, on the opposite side of the gate's ring and
    /// never closer to the centre than ShardMinX - so a dragon that never steers keeps its
    /// clearance all the way down, and a shard never overlaps the ring it shares a gate
    /// with. A CHOICE gate is skipped outright: its second ring already occupies the side
    /// the shard would go to.
    /// </summary>
    private void _0xd7555d2d(_0x262b3467[] _0xfde646a1, int _0x424f874c, System.Random _0x5d6bb825)
    {
        List<int> _0xf8481d9a = new List<int>();
        for (int _0x951920bc = 6; _0x951920bc < _0xfde646a1.Length; _0x951920bc++)
        {
            if (!_0xfde646a1[_0x951920bc].HasSecondRing)
            {
                _0xf8481d9a.Add(_0x951920bc);
            }
        }

        float _0xe4aafb91 = _0x531552b7.LaneHalf - (_0x531552b7.ShardD * 0.5f);
        int _0xe2a110c1 = Mathf.Min(Mathf.Max(_0x424f874c, 0), _0xf8481d9a.Count);
        int _0x6216bb90 = 0;
        while (_0x6216bb90 < _0xe2a110c1 && _0xf8481d9a.Count > 0)
        {
            int _0x230cf44f = _0x5d6bb825.Next(0, _0xf8481d9a.Count);
            _0x262b3467 _0xe48071fe = _0xfde646a1[_0xf8481d9a[_0x230cf44f]];
            _0xf8481d9a.RemoveAt(_0x230cf44f);
            // clear of the ring on the far side, and clear of the centre lane
            float _0x8e49e233 = Mathf.Abs(_0xe48071fe.RingAx) + (_0x531552b7.RingOuter * 0.5f) + (_0x531552b7.ShardD * 0.5f) + 8f;
            float _0x2aea8fbb = Mathf.Max(_0x531552b7.ShardMinX, _0x8e49e233);
            if (_0x2aea8fbb > _0xe4aafb91)
            {
                continue;
            }

            _0xe48071fe.HasShard = true;
            _0xe48071fe.ShardX = (_0xe48071fe.RingAx > 0f ? -1f : 1f) * Mathf.Lerp(_0x2aea8fbb, _0xe4aafb91, (float)_0x5d6bb825.NextDouble());
            _0x6216bb90++;
        }
    }

    public _0xe9121302 _0x89a3ad95(_0xf6a1b425 _0x3366c741, int _0x8f4602db)
    {
        _0xe9121302 _0x2abbcfab = new _0xe9121302();
        _0x2abbcfab.Seed = _0x8f4602db;
        _0x2abbcfab.IsFallback = false;
        int _0x29f8e75c = Mathf.Max(_0x3366c741.Gates, 4);
        System.Random _0x6aeb9654 = new System.Random(_0x8f4602db);
        bool[] _0xf5d454b0 = this._0x42afdcc5(_0x29f8e75c, _0x3366c741.DriftRatio, _0x6aeb9654);
        _0x262b3467[] _0x58b9c73d = new _0x262b3467[_0x29f8e75c];
        for (int _0x25de15da = 0; _0x25de15da < _0x29f8e75c; _0x25de15da++)
        {
            _0x58b9c73d[_0x25de15da] = new _0x262b3467();
            _0x58b9c73d[_0x25de15da].IsDrift = _0xf5d454b0[_0x25de15da];
        }

        this._0xdd68168d(_0x58b9c73d, _0x3366c741.ChoiceGates, _0x6aeb9654);
        this._0xf3ebda26(_0x58b9c73d, _0x6aeb9654);
        this._0x6730001e(_0x58b9c73d, _0x6aeb9654);
        this._0xd7555d2d(_0x58b9c73d, _0x3366c741.Shards, _0x6aeb9654);
        _0x2abbcfab.Gates = _0x58b9c73d;
        if (!this._0x532656b2(_0x2abbcfab, _0x3366c741))
        {
            _0x2abbcfab = this._0x466d934f(_0x3366c741, _0x8f4602db);
        }

        {
#if B_LOGS
            {
                Debug.Log($"[course] seed={_0x8f4602db} gates={_0x2abbcfab.Gates.Length} fallback={_0x2abbcfab.IsFallback}");
            }
#endif
        }

        return _0x2abbcfab;
    }

    /// <summary>
    /// Choice gates are taken from the HARD gates only: both of their rings sit at
    /// +/- ChoiceX, far outside the drift band, so a drift gate could never be one.
    /// </summary>
    private void _0xdd68168d(_0x262b3467[] _0xd32c9b43, int _0xc06f13d8, System.Random _0x45dc69a0)
    {
        List<int> _0x45777cae = new List<int>();
        for (int _0xc0fef77b = 1; _0xc0fef77b < _0xd32c9b43.Length; _0xc0fef77b++)
        {
            if (!_0xd32c9b43[_0xc0fef77b].IsDrift)
            {
                _0x45777cae.Add(_0xc0fef77b);
            }
        }

        int _0xe8573154 = Mathf.Min(Mathf.Max(_0xc06f13d8, 0), _0x45777cae.Count);
        for (int _0xa8d5262d = 0; _0xa8d5262d < _0xe8573154; _0xa8d5262d++)
        {
            int _0x3b2de769 = _0x45dc69a0.Next(0, _0x45777cae.Count);
            _0xd32c9b43[_0x45777cae[_0x3b2de769]].HasSecondRing = true;
            _0x45777cae.RemoveAt(_0x3b2de769);
        }
    }

    private void _0xf3ebda26(_0x262b3467[] _0x7e87ec7e, System.Random _0x9c788f5f)
    {
        float _0x7a4df270 = _0x531552b7.DriftBand + 24f;
        float _0xb529e409 = _0x531552b7.LaneHalf - (_0x531552b7.RingOuter * 0.5f);
        float _0xf18f74b0 = _0x531552b7.DriftBand * 0.75f;
        for (int _0xedfb97ba = 0; _0xedfb97ba < _0x7e87ec7e.Length; _0xedfb97ba++)
        {
            _0x262b3467 _0x77ee0d0d = _0x7e87ec7e[_0xedfb97ba];
            if (_0x77ee0d0d.HasSecondRing)
            {
                _0x77ee0d0d.RingAx = -_0x531552b7.ChoiceX;
                _0x77ee0d0d.RingBx = _0x531552b7.ChoiceX;
                continue;
            }

            if (_0x77ee0d0d.IsDrift)
            {
                _0x77ee0d0d.RingAx = Mathf.Lerp(-_0xf18f74b0, _0xf18f74b0, (float)_0x9c788f5f.NextDouble());
                continue;
            }

            float _0xf251479d = Mathf.Lerp(_0x7a4df270, _0xb529e409, (float)_0x9c788f5f.NextDouble());
            _0x77ee0d0d.RingAx = _0x9c788f5f.Next(0, 2) == 0 ? -_0xf251479d : _0xf251479d;
        }
    }

    /// <summary>
    /// Stratified sampling first, then a repair pass that converts the middle gate of any
    /// run of three hard gates. Converting only ever ADDS drift gates, so the share
    /// invariant cannot be broken by the repair - the spacing is true by construction.
    /// </summary>
    private bool[] _0x42afdcc5(int _0xd060b0f7, float _0x78ed6598, System.Random _0x193d22e3)
    {
        bool[] _0x1e9e45c3 = new bool[_0xd060b0f7];
        int _0x5f55bcec = Mathf.Clamp(Mathf.CeilToInt(_0xd060b0f7 * Mathf.Clamp01(_0x78ed6598)), 1, _0xd060b0f7);
        float _0xf00329e9 = (float)_0xd060b0f7 / _0x5f55bcec;
        for (int _0x2b8d38c6 = 0; _0x2b8d38c6 < _0x5f55bcec; _0x2b8d38c6++)
        {
            int _0xee870ccb = Mathf.FloorToInt(_0x2b8d38c6 * _0xf00329e9);
            int _0x6421ad7d = Mathf.Min(Mathf.FloorToInt((_0x2b8d38c6 + 1) * _0xf00329e9), _0xd060b0f7) - 1;
            if (_0x6421ad7d < _0xee870ccb)
            {
                _0x6421ad7d = _0xee870ccb;
            }

            int _0x608bc4a1 = Mathf.Clamp(_0xee870ccb + _0x193d22e3.Next(0, (_0x6421ad7d - _0xee870ccb) + 1), 0, _0xd060b0f7 - 1);
            _0x1e9e45c3[_0x608bc4a1] = true;
        }

        int _0xaa4377a7 = 0;
        for (int _0xc818df6e = 0; _0xc818df6e < _0xd060b0f7; _0xc818df6e++)
        {
            if (_0x1e9e45c3[_0xc818df6e])
            {
                _0xaa4377a7 = 0;
                continue;
            }

            _0xaa4377a7++;
            if (_0xaa4377a7 > MaxConsecutiveHard)
            {
                _0x1e9e45c3[_0xc818df6e] = true;
                _0xaa4377a7 = 0;
            }
        }

        return _0x1e9e45c3;
    }

    private bool _0x532656b2(_0xe9121302 _0x84e7153d, _0xf6a1b425 _0xce8809c9)
    {
        _0x262b3467[] _0xa64d1408 = _0x84e7153d.Gates;
        if (_0xa64d1408 == null || _0xa64d1408.Length < 4)
        {
            return false;
        }

        int _0x275e932b = 0;
        int _0xbca3f5c6 = 0;
        for (int _0x08750e45 = 0; _0x08750e45 < _0xa64d1408.Length; _0x08750e45++)
        {
            _0x262b3467 _0x0358c6be = _0xa64d1408[_0x08750e45];
            bool _0xdfd3afd2 = Mathf.Abs(_0x0358c6be.RingAx) <= _0x531552b7.RingInnerR || (_0x0358c6be.HasSecondRing && Mathf.Abs(_0x0358c6be.RingBx) <= _0x531552b7.RingInnerR);
            if (_0xdfd3afd2)
            {
                _0x275e932b++;
                _0xbca3f5c6 = 0;
            }
            else
            {
                _0xbca3f5c6++;
                if (_0xbca3f5c6 > MaxConsecutiveHard)
                {
                    return false;
                }
            }

            if (_0x0358c6be.HasShard && Mathf.Abs(_0x0358c6be.ShardX) < _0x531552b7.ShardMinX)
            {
                return false;
            }
        }

        return _0x275e932b >= Mathf.CeilToInt(_0xa64d1408.Length * Mathf.Clamp01(_0xce8809c9.DriftRatio));
    }

    private _0x5afdf70c _0x89b6fe3a(System.Random _0x56595e95, _0x5afdf70c _0xf197e6e6)
    {
        int _0x9eb52a07 = 1 + _0x56595e95.Next(0, 2);
        return (_0x5afdf70c)(((int)_0xf197e6e6 + _0x9eb52a07) % 3);
    }

    /// <summary>
    /// The guarantee, not the game: a hand-written layout used only if the generator ever
    /// produced something unsound. Alternating drift and hard gates, no shards.
    /// </summary>
    private _0xe9121302 _0x466d934f(_0xf6a1b425 _0x4782651f, int _0xe970848f)
    {
        int _0xa6f9026b = Mathf.Max(_0x4782651f.Gates, 4);
        _0x262b3467[] _0x3fa40f67 = new _0x262b3467[_0xa6f9026b];
        float _0x80ef8212 = _0x531552b7.DriftBand + 90f;
        for (int _0x890b283a = 0; _0x890b283a < _0xa6f9026b; _0x890b283a++)
        {
            _0x262b3467 _0x71ecd58c = new _0x262b3467();
            _0x71ecd58c.IsDrift = (_0x890b283a % 2) == 0;
            _0x71ecd58c.RingAx = _0x71ecd58c.IsDrift ? 0f : ((_0x890b283a % 4) == 1 ? -_0x80ef8212 : _0x80ef8212);
            _0x71ecd58c.RingAColour = (_0x5afdf70c)(_0x890b283a % 3);
            _0x3fa40f67[_0x890b283a] = _0x71ecd58c;
        }

        _0xe9121302 _0xb6815697 = new _0xe9121302();
        _0xb6815697.Gates = _0x3fa40f67;
        _0xb6815697.Seed = _0xe970848f;
        _0xb6815697.IsFallback = true;
        return _0xb6815697;
    }

    private _0x5afdf70c _0xc596f6ad(System.Random _0x585347b7, _0x5afdf70c _0x18f92056, int _0x44da7747)
    {
        if (_0x44da7747 >= 2)
        {
            return this._0x89b6fe3a(_0x585347b7, _0x18f92056);
        }

        return (_0x5afdf70c)_0x585347b7.Next(0, 3);
    }
}