using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private GameObject _deathPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.GetComponent<EnemyMainCollider>())
        {
            _deathPanel.SetActive(true);
            Destroy(gameObject);
        }
    }
}
