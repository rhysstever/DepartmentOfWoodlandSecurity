using UnityEngine;
using UnityEngine.UI;

public class TutorialButtonPanel : MonoBehaviour
{
    [SerializeField]
    private Button previousButton, nextButton;
    [SerializeField]
    private GameObject previousPanel, nextPanel;

    void Start()
    {
        gameObject.SetActive(false);

        if(previousButton != null)
        {
            previousButton.onClick.AddListener(() => {
                if(previousPanel != null)
                {
                    previousPanel.SetActive(true);
                }
                gameObject.SetActive(false);
            });
        }

        if(nextButton != null)
        {
            nextButton.onClick.AddListener(() => {
                if(nextPanel != null)
                {
                    nextPanel.SetActive(true);
                    if(nextPanel.name == "playing cards" || nextPanel.name == "playing targeting cards")
                    {
                        TutorialManager.instance.SetTutorialHandStage(1);
                    }
                    else if(nextPanel.name == "end turn")
                    {
                        TutorialManager.instance.SetTutorialHandStage(2);
                    }
                }
                gameObject.SetActive(false);

                if(gameObject.name == "end")
                {
                    TutorialManager.instance.EndTutorial();
                }
            });
        }
    }
}
