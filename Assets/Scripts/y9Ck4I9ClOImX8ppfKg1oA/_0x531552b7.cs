using UnityEngine;

/// <summary>
/// Every size in this game is derived from the canvas reference resolution, never
/// eyeballed (C.0, applied to a UGUI build: the canvas is the frame of reference the
/// camera is for world sprites). The panels hang under an AspectRatioFitter locked to
/// 1242x2688, so panel space IS the reference resolution on every device.
///
/// The design document is written in camera units (ortho size 5, 19.5:9 -> half width
/// 2.3077). PixelsPerWorld converts those numbers once, here, so no call site repeats
/// the conversion.
/// </summary>
public static class _0x531552b7
{
    public const float MinHoldSeconds = 0.35f; // the tap latch: one capture tap = a real swing
    public const float SizeAction = 48f;
    public const int ShardsPerScore = 20;
    public const float SpawnY = 2888f; // a gate enters just above the panel
    public const float SizeSection = 56f;
    public const float ChainCap = 4f;
    // --- run balance (C.5: a passive run outlives the capture window) --------------
    public const float IntroSeconds = 3.0f;
    public const float AetherOnMiss = -8f;
    public const float TouchZoneTop = 0.70f; // taps above this fraction belong to the HUD
    public const int ScoreOnShard = -250;
    public const float ChoiceX = 283f; // 1.0500 u  - the two rings of a choice gate
    /// <summary>621 panel units across a 2.3077-unit camera half-width.</summary>
    public const float PixelsPerWorld = 269.1f;
    public const float SizeBody = 44f;
    public const float RingOuter = 323f; // 1.2000 u  - ring sprite diameter
    public const int ScorePerGateBonus = 50;
    public const float DragonY = 700f; // the dragon holds this y for the whole run
    public const float MaxDelta = 0.05f; // a frame hitch must not teleport a gate
    // --- type scale (C.12: the floor is 24 px on 1080, i.e. ~28 on this canvas) ----
    public const float SizeHero = 84f;
    public const float SizeHintMin = 32f;
    public const float OutroSeconds = 2.2f;
    public const float AetherMax = 100f;
    public const float PanelW = 1242f;
    public const float SizePlayMin = 54f;
    public const float SizeHeroMin = 56f;
    public const float DragonHalfW = 82f; // 0.3040 u  - half width of the hit test
    public const float ChainStep = 0.25f;
    // --- flight geometry, all = <camera units> * PixelsPerWorld -------------------
    public const float LaneHalf = 498f; // 1.8508 u  - the dragon's x clamp
    public const float AetherOnPass = 10f;
    public const float SizeHint = 38f;
    public const float SizeStrip = 40f;
    public const float PanelH = 2688f;
    // --- control ------------------------------------------------------------------
    public const float SteerRate = 700f; // 2.60 u/s
    public const float ShardD = 143f; // 0.5308 u
    public const float SizeStripMin = 32f;
    public const float DragonH = 255f; // 0.9500 u
    public const float DriftBand = 108f; // 0.4000 u  - inside the pass radius at x = 0
    public const float DespawnY = -260f;
    public const float SizePlay = 76f;
    /// <summary>Uniform size for a square sprite drawn at a given panel height.</summary>
    public static Vector2 Square(float _0x198cfa18)
    {
        return new Vector2(_0x198cfa18, _0x198cfa18);
    }

    public const float PanelCx = 621f;
    public const float SizeSectionMin = 40f;
    public const int ScoreOnPass = 100;
    public const float ShardMinX = 256f; // 0.9500 u  - clear of a dragon that never steers
    public const float GateSpacing = 1559f; // 5.8000 u
    public const float SizeCaptionMin = 32f;
    public const float AetherOnMatch = 14f;
    public const float SizeBodyMin = 32f;
    public const float SizeActionMin = 36f;
    public const float SizeCaption = 36f;
    /// <summary>World units (as the design document writes them) to panel units.</summary>
    public static float FromWorld(float _0x7dac3b10)
    {
        return _0x7dac3b10 * PixelsPerWorld;
    }

    public const float AetherOnShard = -30f;
    public const float LevelRate = 511f; // 1.90 u/s back towards the centre
    public const float RingInnerR = 124f; // 0.4596 u  - pass radius
}