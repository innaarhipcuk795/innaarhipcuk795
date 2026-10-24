using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x014c750c;

public class _0x2bc80d8c : MonoBehaviour
{
    public static _0x2bc80d8c Instance;
    public static _0x474405fe _0x2eee9eec => _0x474405fe.ALL_SCENES_SETTING_SINGLETONS[Instance._0x880ae377];

    public Transform Environment;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x2bc80d8c>();
        this.RootGameObject = GameObject.FindWithTag(_0x07b51fda._0xe6305385(new byte[4] { 19, 46, 46, 53 }, 65));
        if (this._0x880ae377 == _0x99049008.SCENE_0)
            this._0x99ca33d7(true);
        else
            this._0x99ca33d7(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x80b22b6a>(true).ToList();
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    private void _0x47bd6bae(Transform _0xa5eb7108)
    {
        Transform[] _0xb3413f48 = _0xa5eb7108.GetComponentsInChildren<Transform>();
        foreach (Transform _0x7f7a1a1f in _0xb3413f48)
            if (_0x7f7a1a1f != null && DOTween.IsTweening(_0x7f7a1a1f))
            {
                if (this._0x41e1785e)
                    DOTween.Play(_0x7f7a1a1f);
                else
                    DOTween.Pause(_0x7f7a1a1f);
            }
    }

    public Button DeleteProgressDataButton;
    private static _0x474405fe GAME_INDEX_SETTINGS(int _0x8921a739)
    {
        return _0x474405fe.ALL_SCENES_SETTING_SINGLETONS[_0x8921a739];
    }

    public void _0x32a7466a()
    {
        _0x2eee9eec._0xd7f97786 = true;
    }

    private IEnumerator _0xe84266dd(string _0x4e566c81)
    {
        _0x84e527ab.Instance._0x24f58fbd(_0x50016d8c.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x45ba7c76 = SceneManager.LoadSceneAsync(_0x4e566c81);
        while (!_0x45ba7c76.isDone)
            yield return null;
    }

    private void _0xbb6d63ba()
    {
        IsAfterLevelComplete = true;
        Instance._0xf6240625(_0x99049008.SCENE_0);
    }

    [HideInInspector]
    public List<_0x80b22b6a> MoneyCountContainers = new();
    public void _0xe8fcd4e3()
    {
        this._0xf6240625(SceneManager.GetActiveScene().buildIndex);
    }

    public Transform EnvironmentWithTweensToToggle;
    public bool _0x41e1785e { get; private set; }

    public static bool IsAfterLevelFailed = false;
    public Canvas MainCanvas;
    public static bool IsAfterLevelComplete;
    private static _0x474405fe _0xe30d4706 => _0x474405fe.ALL_SCENES_SETTING_SINGLETONS[0];

    private void Start()
    {
        if (this._0x880ae377 != _0x99049008.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0xf6240625(_0x99049008.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x2eee9eec._0xd7f97786 = false;
            _0x17c8dcf5.Instance._0xb450d753();
            _0x84e527ab.Instance._0x24f58fbd(_0x50016d8c.TUTORIAL0);
        });
    }

    public void _0xf6240625(int _0xfdb3c061)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xb8ddb622(_0xfdb3c061));
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private static void MakeGrid(List<RectTransform> _0x62bad8aa, AspectRatioFitter _0xd1ea9e54, float _0x200c3b98, int _0x49e221b4, int _0x4e1e1a5c)
    {
        _0xd1ea9e54.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xd1ea9e54.aspectRatio = _0x200c3b98;
        foreach (RectTransform _0x703a6b91 in _0x62bad8aa)
        {
            int _0x184d9e95 = _0x703a6b91.transform.GetSiblingIndex();
            _0x703a6b91.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x184d9e95 % _0x49e221b4) * (1f / _0x49e221b4), (_0x4e1e1a5c - (Mathf.FloorToInt((float)_0x184d9e95 / _0x49e221b4) % _0x4e1e1a5c + 1f)) * (1f / _0x4e1e1a5c));
            _0x703a6b91.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x184d9e95 % _0x49e221b4 + 1f) * (1f / _0x49e221b4), (_0x4e1e1a5c - Mathf.FloorToInt((float)_0x184d9e95 / _0x49e221b4) % _0x4e1e1a5c) * (1f / _0x4e1e1a5c));
            _0x703a6b91.offsetMin = Vector2.zero;
            _0x703a6b91.offsetMax = Vector2.zero;
        }
    }

    public void _0xb8072ac8()
    {
        foreach (_0x80b22b6a _0x5e2c5003 in this.MoneyCountContainers)
            _0x5e2c5003._0x90ae0bef();
    }

    public Button ShowResetTutorialButton;
    private void _0x55e641d7(bool _0x88980c93)
    {
        Rigidbody2D[] _0x887a2d6d = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xee10d95a in _0x887a2d6d)
            if (_0x88980c93)
                _0xee10d95a.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xee10d95a.constraints = RigidbodyConstraints2D.None;
    }

    public int _0x880ae377 => SceneManager.GetActiveScene().buildIndex;

    public void _0x99ca33d7(bool _0xbf684e6f)
    {
        this._0x41e1785e = _0xbf684e6f;
        this._0x55e641d7(!this._0x41e1785e);
        Physics2D.simulationMode = this._0x41e1785e ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x47bd6bae(this.EnvironmentWithTweensToToggle);
    }

    private IEnumerator _0xb8ddb622(int _0xe311ba92)
    {
        _0x84e527ab.Instance._0x24f58fbd(_0x50016d8c.SPLASH);
        AsyncOperation _0x97895a46 = SceneManager.LoadSceneAsync(_0xe311ba92);
        while (!_0x97895a46.isDone)
            yield return null;
    }
}

internal static class _0x07b51fda
{
    internal static string _0xe6305385(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}