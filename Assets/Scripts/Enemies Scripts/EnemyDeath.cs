using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private Collider2D _deathCollider;
    [SerializeField] private Collider2D _mainCollider;

    private Animator _enemyAnimator;
    private int _enemyAnimationHash;

    private void Start()
    {
        _enemyAnimator = GetComponent<Animator>();
        _enemyAnimationHash = Animator.StringToHash("isDeath");
    }

    public void EnemyDying()
    {
        _deathCollider.enabled = false;
        _mainCollider.enabled = false;
        _enemyAnimator.SetTrigger(_enemyAnimationHash);
        Destroy(gameObject, _enemyAnimator.GetCurrentAnimatorStateInfo(0).length);
    }
}
