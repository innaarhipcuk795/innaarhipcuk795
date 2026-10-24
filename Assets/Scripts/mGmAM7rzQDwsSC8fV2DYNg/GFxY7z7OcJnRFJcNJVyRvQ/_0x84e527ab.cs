using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x014c750c;

public class _0x84e527ab : MonoBehaviour
{
    public static _0x84e527ab Instance;
    public float ScaleDuration = 0.4f;
    private void _0xadd886ec(int _0x8fa4c05c)
    {
        if (_0x8fa4c05c == _0x50016d8c.SPLASH)
            _0xe6b3ba0e.Instance._0x1adf167c();
        if (_0x2bc80d8c.Instance._0x880ae377 == _0x99049008.SCENE_0)
        {
        }
    }

    public void _0x24f58fbd(int _0xab42a18d)
    {
        this._0x97a456c1(_0xab42a18d);
        this._0xadd886ec(_0xab42a18d);
        this.CurrentPanelIndex = _0xab42a18d;
        this.Panels[_0xab42a18d].Show();
    }

    private void Start()
    {
        this._0xeed5e3ed();
    }

    public void _0x55cb0024()
    {
        this.LastPanelIndexes.RemoveAll(_0xffff588a => _0xffff588a == this.CurrentPanelIndex);
        int _0x3f0cc2bd = this.LastPanelIndexes.Last();
        this._0xadd886ec(_0x3f0cc2bd);
        this._0x79140ac4(_0x3f0cc2bd);
        this.CurrentPanelIndex = _0x3f0cc2bd;
        this.Panels[_0x3f0cc2bd].Show();
    }

    private void _0x97a456c1(int _0x90400018)
    {
        this.LastPanelIndexes.Add(_0x90400018);
        this.CurrentPanelIndex = _0x90400018;
        for (int _0x22306bbf = 0; _0x22306bbf < this.Panels.Count; _0x22306bbf++)
            if (_0x22306bbf != _0x90400018 && this.Panels[_0x22306bbf] != null)
                this.Panels[_0x22306bbf]._0x55f466f6();
    }

    private void _0x79140ac4(int _0xbbb89843)
    {
        this.LastPanelIndexes.Add(_0xbbb89843);
        this.CurrentPanelIndex = _0xbbb89843;
        for (int _0xf257c38f = 0; _0xf257c38f < this.Panels.Count; _0xf257c38f++)
            if (_0xf257c38f != _0xbbb89843 && this.Panels[_0xf257c38f] != null)
                this.Panels[_0xf257c38f]._0x55f466f6();
    }

    private void _0x9383ddc9(int _0xb7f49238)
    {
        this._0x97a456c1(_0xb7f49238);
        this._0xadd886ec(_0xb7f49238);
        this.CurrentPanelIndex = _0xb7f49238;
        this.Panels[_0xb7f49238]._0x421bd8aa();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x84e527ab>();
    }

    private _0xabf57bd7 _0x203b91f2(int _0x267dd772)
    {
        return this.Panels[_0x267dd772];
    }

    public bool IsShowSplashOnStart = true;
    private void _0xeed5e3ed()
    {
        this._0x9383ddc9(_0x50016d8c.SPLASH);
        if (_0x2bc80d8c.Instance._0x880ae377 == _0x99049008.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xe6b3ba0e.Instance.DefaultAnimationTime);
        }
    }

    public int CurrentPanelIndex;
    public float StaticBlurMaterialInitialValue;
    private void SwitchSplash()
    {
        if (_0xf6d99b66.Instance.IsTutorialEnabled && !_0x2bc80d8c._0x2eee9eec._0xd7f97786)
            this._0x24f58fbd(_0x50016d8c.TUTORIAL0);
        else
            this._0x24f58fbd(_0x50016d8c.DEFAULT);
    }

    public List<_0xabf57bd7> Panels;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public void _0x382a6157(int _0xa778b355)
    {
        if (_0xa778b355 == _0x50016d8c.SPLASH && _0x2bc80d8c.Instance._0x880ae377 != _0x99049008.SCENE_0)
            _0xe6b3ba0e.Instance._0xdb66c152();
        if (_0x2bc80d8c.Instance._0x880ae377 != _0x99049008.SCENE_0)
        {
            if (_0xa778b355 == _0x50016d8c.SPLASH || _0xa778b355 == _0x50016d8c.TUTORIAL0)
                _0x2bc80d8c.Instance._0x99ca33d7(false);
            else if (_0xa778b355 == _0x50016d8c.DEFAULT)
                _0x2bc80d8c.Instance._0x99ca33d7(true);
        }
    }
}