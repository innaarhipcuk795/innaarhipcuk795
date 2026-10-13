using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x014c750c;

public class _0x17c8dcf5 : MonoBehaviour
{
    public _0x7e67a501 _0x72c529be(int _0xb8a1af8f)
    {
        return this.Pops[_0xb8a1af8f];
    }

    public void _0xb450d753()
    {
        this.LastPopIndexes.Clear();
        this._0x3dcdd780();
        foreach (GameObject _0x307a9dbf in this.GameObjectsToHide)
            if (_0x307a9dbf != null)
                _0x307a9dbf.SetActive(true);
        this._0xe7985214();
    }

    public List<_0x7e67a501> Pops;
    private void _0x3dcdd780(bool _0x277fdb10 = false)
    {
        for (int _0x16708f14 = 0; _0x16708f14 < this.Pops.Count; ++_0x16708f14)
            if (this.Pops[_0x16708f14] != null && !(_0x16708f14 == this.CurrentPopIndex && _0x277fdb10))
                this.Pops[_0x16708f14]._0xbb0c5a2c();
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public List<GameObject> GameObjectsToHide;
    public int CurrentPopIndex;
    public static _0x17c8dcf5 Instance;
    private void _0xe7985214()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public float ScaleDuration = 0.4f;
    private void _0x93430945()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public void _0xb2f8fd68(int _0xf6ac1c7d)
    {
        this.CurrentPopIndex = _0xf6ac1c7d;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x3dcdd780(true);
        this._0x93430945();
        this.Pops[_0xf6ac1c7d].Show();
        foreach (GameObject _0x6d81a0d1 in this.GameObjectsToHide)
            _0x6d81a0d1.SetActive(false);
    }

    public void _0x913e141d()
    {
        this.LastPopIndexes.RemoveAll(_0xffff588a => _0xffff588a == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xb450d753();
        else
            this._0xb2f8fd68(this.LastPopIndexes.Last());
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x17c8dcf5>();
    }

    public GameObject BlurBackground;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x7e67a501 _0xe1c4040b in this.Pops)
            if (_0xe1c4040b != null)
                _0xe1c4040b.gameObject.SetActive(true);
    }

    public List<int> LastPopIndexes = new();
}