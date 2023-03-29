using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private Collider2D _deathCollider;
    [SerializeField] private Collider2D _mainCollider;

    private Animator _enemyAnimator;

    private void Start()
    {
        _enemyAnimator = GetComponent<Animator>();
    }

    public void EnemyDying()
    {
        _deathCollider.enabled = false;
        _mainCollider.enabled = false;
        _enemyAnimator.SetTrigger("isDeath");
        Destroy(gameObject, _enemyAnimator.GetCurrentAnimatorStateInfo(0).length);
    }
}
