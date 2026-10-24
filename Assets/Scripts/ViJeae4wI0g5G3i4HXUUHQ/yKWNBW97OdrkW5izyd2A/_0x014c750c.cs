using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x014c750c
{
    public static class _0x99049008
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0xbaa4f890
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0x474405fe
    {
        private static readonly _0x474405fe _0x2556eea6 = new();
        public static readonly _0x474405fe[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x2556eea6,
            _0x2556eea6,
            _0x2556eea6,
        };
        private int _0x48cb9f61 => 0;
        private int _0xf49e55b8 => 10;
        private string _0xb73d304f => _0x99ae984d._0x917f75e0(new byte[4] { 222, 246, 253, 230 }, 147);
        private string _0x6a28236a => _0x99ae984d._0x917f75e0(new byte[8] { 150, 159, 140, 159, 150, 161, 234, 167 }, 218);

        private int _0x7512adeb
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x99ae984d._0x917f75e0(new byte[25] { 178, 132, 131, 131, 148, 159, 133, 182, 157, 158, 147, 144, 157, 178, 153, 144, 129, 133, 148, 131, 184, 159, 149, 148, 137 }, 241)))
                    PlayerPrefs.SetInt(_0x99ae984d._0x917f75e0(new byte[25] { 251, 205, 202, 202, 221, 214, 204, 255, 212, 215, 218, 217, 212, 251, 208, 217, 200, 204, 221, 202, 241, 214, 220, 221, 192 }, 184), 0);
                return PlayerPrefs.GetInt(_0x99ae984d._0x917f75e0(new byte[25] { 137, 191, 184, 184, 175, 164, 190, 141, 166, 165, 168, 171, 166, 137, 162, 171, 186, 190, 175, 184, 131, 164, 174, 175, 178 }, 202));
            }

            set => PlayerPrefs.SetInt(_0x99ae984d._0x917f75e0(new byte[25] { 98, 84, 83, 83, 68, 79, 85, 102, 77, 78, 67, 64, 77, 98, 73, 64, 81, 85, 68, 83, 104, 79, 69, 68, 89 }, 33), value);
        }

        public int _0xab263368
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xb73d304f}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xb73d304f}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xb73d304f}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xb73d304f}CurrentLevelIndex", value);
        }

        public int _0x1d884ace
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xb73d304f}BestScore"))
                    this._0x1d884ace = 0;
                return PlayerPrefs.GetInt($"{this._0xb73d304f}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xb73d304f}BestScore", value);
        }

        public bool _0xd7f97786
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xb73d304f}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xb73d304f}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xb73d304f}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xb73d304f}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x50016d8c
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x197748fa
    {
        public static int _0x43e96ed6
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x99ae984d._0x917f75e0(new byte[5] { 54, 26, 28, 27, 6 }, 117)))
                    PlayerPrefs.SetInt(_0x99ae984d._0x917f75e0(new byte[5] { 240, 220, 218, 221, 192 }, 179), 0);
                return PlayerPrefs.GetInt(_0x99ae984d._0x917f75e0(new byte[5] { 160, 140, 138, 141, 144 }, 227));
            }

            set
            {
                PlayerPrefs.SetInt(_0x99ae984d._0x917f75e0(new byte[5] { 13, 33, 39, 32, 61 }, 78), value);
                _0x2bc80d8c.Instance._0xb8072ac8();
            }
        }
    }
}

internal static class _0x99ae984d
{
    internal static string _0x917f75e0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}