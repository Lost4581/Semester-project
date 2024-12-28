using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialButton : MonoBehaviour
{
    [SerializeField] private GameObject TutorialPanel;
    [SerializeField] private Button Tutorial_Button;
    [SerializeField] private Button Exit_Button;

    private void Update()
    {
        Tutorial_Button.onClick.AddListener(OpenTutorialPanel);
        Exit_Button.onClick.AddListener(ExitTutorialPanel);
    }

    public void OpenTutorialPanel()
    {
        TutorialPanel.SetActive(true);
    }

    private void ExitTutorialPanel()
    {
        TutorialPanel.SetActive(false);
    }
}
