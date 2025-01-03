using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private GameObject RestartPanel;
    [SerializeField] private int startHP;
    [SerializeField] private LayerMask damageLayerMask;
    [SerializeField] public TextMeshProUGUI healthText;
    public int _currHP;

    private void Awake()
    {
        _currHP = startHP;
        DrawHP();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (LayerMaskUtil.ContainsLayer(damageLayerMask, collision.gameObject))
        {
            if (collision.gameObject.TryGetComponent(out StaticEnemy enemy))
            {
                if (enemy.CanDamage)
                    GetDamage(enemy.Damage);
            }

        }
    }

    private void GetDamage(int damage)
    {
        if (_currHP > 0)
        {
            _currHP -= damage;
            healthText.text = $"HP: {_currHP}";
        }
        if (_currHP <= 0)
        {
            Time.timeScale = 0;
            RestartPanel.SetActive(true);
        }
    }
    private void DrawHP()
    {
        healthText.text = $"HP: {_currHP}";
    }
}
