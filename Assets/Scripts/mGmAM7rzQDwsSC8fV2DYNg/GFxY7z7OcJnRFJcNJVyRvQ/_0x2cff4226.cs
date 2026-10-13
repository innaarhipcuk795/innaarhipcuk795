using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x2cff4226 : MonoBehaviour
{
    [HideInInspector]
    public int CurrentGameIndex;
    private IEnumerator _0xe64f501d()
    {
        this._0x874d5c49();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x2bc80d8c.Instance._0x880ae377 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x2bc80d8c.Instance._0x41e1785e)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x874d5c49();
            }
        }

        if (!this.IsGameEnd)
            this._0x8a0735b9();
    }

    private void _0x6e2586c3()
    {
        if (_0xf6d99b66.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xa6a37741 => _0xa6a37741.text = $"{this.ScoreCurrent}/{this._0x0bdc7500}");
        else
            this.ScoreText.ForEach(_0xa6a37741 => _0xa6a37741.text = $"{this.ScoreCurrent}");
    }

    private void _0x6af5d767()
    {
        if (this.ScoreCurrent > _0x2bc80d8c._0x2eee9eec._0x1d884ace)
            _0x2bc80d8c._0x2eee9eec._0x1d884ace = this.ScoreCurrent;
        if (_0xf6d99b66.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x0bdc7500)
                this._0x9150bdf8();
    }

    private int _0xbb5d04bb => this.ScoreCurrent;

    public List<TMP_Text> TimerText = new();
    public void _0x9150bdf8()
    {
        if (!this.IsGameEnd)
        {
            this._0x3bd8b369();
            _0x2bc80d8c.IsAfterLevelComplete = true;
            _0x2bc80d8c.IsAfterLevelFailed = false;
            _0x7e67a501 _0xfcf627ee = _0x17c8dcf5.Instance._0x72c529be(_0x014c750c._0xbaa4f890.WIN).GetComponent<_0x7e67a501>();
            if (_0xf6d99b66.Instance.IsCheckScoreEnabled)
                _0xfcf627ee.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x0bdc7500}";
            else
                _0xfcf627ee.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xf6d99b66.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x014c750c._0x197748fa._0x43e96ed6)
                    _0x014c750c._0x197748fa._0x43e96ed6 = this.ScoreCurrent;
                _0xfcf627ee.ContentAdditionalText.text = $"{_0x014c750c._0x197748fa._0x43e96ed6}";
            }
            else
            {
                _0xfcf627ee.ContentAdditionalText.text = $"{this._0xbb5d04bb}";
                _0x014c750c._0x197748fa._0x43e96ed6 += this._0xbb5d04bb;
            }

            if (_0xf6d99b66.Instance.IsLevelIncrementOnWin)
                ++_0x2bc80d8c._0x2eee9eec._0xab263368;
            _0x17c8dcf5.Instance._0xb2f8fd68(_0x014c750c._0xbaa4f890.WIN);
        }
    }

    private int _0x0bdc7500 => this.CustomTargetScore + _0x2bc80d8c._0x2eee9eec._0xab263368 * 10;

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xc675e557;
        this.CurrentGameIndex = _0x2bc80d8c.Instance._0x880ae377;
        foreach (Button _0x02f662c1 in this.HomeButtons)
            _0x02f662c1.onClick.AddListener(() =>
            {
                this._0xbb74d930();
            });
        foreach (Button _0x5dfe28b2 in this.PauseButtons)
            _0x5dfe28b2.onClick.AddListener(() =>
            {
                _0x2bc80d8c.Instance._0x99ca33d7(false);
                _0x17c8dcf5.Instance._0xb2f8fd68(_0x014c750c._0xbaa4f890.PAUSE);
            });
        this._0x6e2586c3();
        this.LevelNumberText.ForEach(_0xa6a37741 => _0xa6a37741.text = $"LVL {_0x2bc80d8c._0x2eee9eec._0xab263368 + 1}");
        if (_0xf6d99b66.Instance.IsTimerEnabled)
        {
            this._0x874d5c49();
            this.StartCoroutine(this._0xe64f501d());
        }
    }

    public List<Button> HomeButtons = new();
    [HideInInspector]
    public int ScoreCurrent;
    public void _0xa6f72883(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x6e2586c3();
            this._0x6af5d767();
        }
    }

    private void _0xe07e09e0()
    {
        if (this.ScoreCurrent >= this._0x0bdc7500)
            this._0x9150bdf8();
        else
            this._0x8a0735b9();
    }

    private void _0x874d5c49()
    {
        this.TimerText.ForEach(_0xa6a37741 => _0xa6a37741.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x4daa1be3._0x718172fd(new byte[6] { 194, 194, 243, 149, 220, 220 }, 175)));
    }

    public void _0x8a0735b9()
    {
        if (_0xf6d99b66.Instance.IsOnlyWinGameEndEnabled)
            this._0x9150bdf8();
        if (!this.IsGameEnd)
        {
            this._0x3bd8b369();
            _0x2bc80d8c.IsAfterLevelComplete = false;
            _0x2bc80d8c.IsAfterLevelFailed = true;
            _0x7e67a501 _0x0e9711fe = _0x17c8dcf5.Instance._0x72c529be(_0x014c750c._0xbaa4f890.LOSE).GetComponent<_0x7e67a501>();
            if (_0xf6d99b66.Instance.IsCheckScoreEnabled)
                _0x0e9711fe.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x0bdc7500}";
            else
                _0x0e9711fe.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x0e9711fe.ContentAdditionalText.text = $"{0}";
            _0x014c750c._0x197748fa._0x43e96ed6 += 0;
            _0x17c8dcf5.Instance._0xb2f8fd68(_0x014c750c._0xbaa4f890.LOSE);
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
    public int CustomTimeInitial = 30;
    public List<TMP_Text> SubtitleText = new();
    public List<TMP_Text> LevelNumberText = new();
    private void Awake()
    {
        _0x030cd77b = this.gameObject.GetComponent<_0x2cff4226>();
    }

    [HideInInspector]
    public int TimeLeft;
    private int _0xc675e557 => this.CustomTimeInitial + _0x2bc80d8c._0x2eee9eec._0xab263368 * 10;

    public int CustomTargetScore = 10;
    public List<Button> PauseButtons = new();
    public List<TMP_Text> ScoreText = new();
    public void _0xbb74d930()
    {
        _0x2bc80d8c.Instance._0x99ca33d7(true);
        _0x2bc80d8c.Instance._0xf6240625(_0x014c750c._0x99049008.SCENE_0);
    }

    private static _0x2cff4226 _0x030cd77b;
    private void _0x3bd8b369()
    {
        this.IsGameEnd = true;
        _0x2bc80d8c.IsAfterLevelComplete = true;
    }
}

internal static class _0x4daa1be3
{
    internal static string _0x718172fd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}