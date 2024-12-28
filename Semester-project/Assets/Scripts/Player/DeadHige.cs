using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadHige : MonoBehaviour
{
    [SerializeField] private GameObject RestartPanel;
    public int hight = -25;

    void Update()
    {
        if (transform.position.y <= hight)
        {
            Time.timeScale = 0;
            RestartPanel.SetActive(true);
        }
    }
}
