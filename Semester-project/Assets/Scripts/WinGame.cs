using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    [SerializeField] private GameObject WinScreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        WinScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
