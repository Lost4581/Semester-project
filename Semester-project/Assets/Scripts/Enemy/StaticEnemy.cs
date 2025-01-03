using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class StaticEnemy : MonoBehaviour
{
    [SerializeField] public GameObject BossEnemy;
    [field: SerializeField] public int Damage { get; private set; }
    public bool CanDamage { get; private set; }
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        CanDamage = true;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out BulletScript _))
        {
            CanDamage = false;
            _spriteRenderer.color = Color.white;
        }
        if (collision.gameObject.TryGetComponent(out BulletScript _) && gameObject == BossEnemy)
        {
            Destroy(gameObject);   
        }
    }
}
