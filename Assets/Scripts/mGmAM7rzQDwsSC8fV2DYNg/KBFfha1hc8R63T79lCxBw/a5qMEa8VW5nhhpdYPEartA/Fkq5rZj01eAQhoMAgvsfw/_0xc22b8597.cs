using UnityEngine;
using UnityEngine.UI;

public class _0xc22b8597 : MonoBehaviour
{
    public Button NextTutorialButton;
    public int EndTutorialPanelIndex = 1;
    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x84e527ab.Instance._0x24f58fbd(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x2bc80d8c.Instance._0x32a7466a());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x84e527ab.Instance._0x24f58fbd(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x84e527ab.Instance._0x24f58fbd(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x2bc80d8c.Instance._0x32a7466a());
        }
    }

    public bool IsTutorialEndPanel;
}