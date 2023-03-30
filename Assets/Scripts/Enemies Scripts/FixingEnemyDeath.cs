using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixingEnemyDeath: MonoBehaviour
{
    [SerializeField] private EnemyDeath _opossum;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            _opossum.EnemyDying();
        }
    }
}
