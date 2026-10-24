using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x8024ac22 : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x2bc80d8c.Instance._0xf6240625(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x2bc80d8c.Instance._0xf6240625(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int LoadSceneId;
}