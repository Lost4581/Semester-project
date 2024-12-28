using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private Button Play_Button;

    private void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        Play_Button.onClick.AddListener(StartGame);
    }
    public void StartGame()
    {
        MenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
