using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerDeath))]
[RequireComponent(typeof(Animator))]

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _allCoins;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private Text _coinCounter;

    private int _numberOfCoins;
    private int _numberOfAllCoins;

    private void Start()
    {
        _numberOfCoins = 0;
        _numberOfAllCoins = _allCoins.transform.childCount;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Coin>())
        {
            _numberOfCoins++;
            _coinCounter.text = "Монеты: " + _numberOfCoins.ToString();

            Destroy(collision.gameObject);

            if (_numberOfCoins == _numberOfAllCoins)
            {
                _winPanel.SetActive(true);
            }
        }
    }
}

