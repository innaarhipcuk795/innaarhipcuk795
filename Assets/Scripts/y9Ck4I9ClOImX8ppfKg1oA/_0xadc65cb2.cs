using TMPro;
using UnityEngine;

/// <summary>
/// Every asset the generated UI needs, as one serialized block on the scene bootstraps.
/// Plain serializable class, not a singleton and not a ScriptableObject: the references
/// live in the scene as {fileID, guid} pairs, which is the only wiring obfuscation
/// cannot break.
/// </summary>
[System.Serializable]
public sealed class _0xadc65cb2
{
    public Sprite IconPause;
    public TMP_FontAsset Font;
    public Sprite Spark;
    public Sprite Shard;
    public Sprite RingGold;
    /// <summary>Built-in 9-slice UI plate; its guid can never go missing.</summary>
    public Sprite Plate;
    public Sprite RingAzure;
    public Sprite RingViolet;
    public Sprite _0x46ad98d8(_0x5afdf70c _0x00b378f5)
    {
        if (_0x00b378f5 == _0x5afdf70c.Gold)
        {
            return this.RingGold;
        }

        if (_0x00b378f5 == _0x5afdf70c.Violet)
        {
            return this.RingViolet;
        }

        return this.RingAzure;
    }

    public Sprite Mark;
    public Sprite Dragon;
    public Sprite IconClose;
    public Sprite IconBack;
}