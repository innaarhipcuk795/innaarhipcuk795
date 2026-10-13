using UnityEngine;

/// <summary>
/// The difficulty of one course. Quantities come from the design document; the PLACEMENT
/// of everything comes from the generator (C.11).
/// </summary>
[System.Serializable]
public sealed class _0xf6a1b425
{
    /// <summary>
    /// Share of gates that must carry a ring a dragon sitting at x = 0 passes through.
    /// This is what makes a run with no input survive the whole course (C.5).
    /// </summary>
    public float DriftRatio = 0.55f;
    public float _0x5a69b43e()
    {
        return this.Pace * _0x531552b7.PixelsPerWorld;
    }

    public int Shards;
    /// <summary>
    /// How long a run lasts with no input at all. The capture takes its first gameplay
    /// frame around second 15-18 and its last around second 30, so this must stay well
    /// above 60 (C.5).
    /// </summary>
    public float _0x93731b2e()
    {
        float _0xa56241b0 = (_0x531552b7.SpawnY - _0x531552b7.DragonY) / Mathf.Max(this._0x5a69b43e(), 1f);
        return _0x531552b7.IntroSeconds + _0xa56241b0 + ((this.Gates - 1) * this._0x1aeb397c()) + _0x531552b7.OutroSeconds;
    }

    /// <summary>Scroll speed in camera units per second, as the design document writes it.</summary>
    public float Pace = 1.35f;
    public int Gates = 18;
    /// <summary>Seconds one gate takes to travel the gap to the next one.</summary>
    public float _0x1aeb397c()
    {
        return _0x531552b7.GateSpacing / Mathf.Max(this._0x5a69b43e(), 1f);
    }

    public int ChoiceGates = 4;
}