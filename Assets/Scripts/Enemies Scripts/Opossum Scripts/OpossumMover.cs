using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody2D))]

public class OpossumMover : MonoBehaviour
{
    [SerializeField] private Vector2[] _wayPoints;
    [SerializeField] private float _speed;

    private Rigidbody2D _opossumRigidbody;

    private void Awake()
    {
        _opossumRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        Tween tween = _opossumRigidbody.DOPath(_wayPoints, _speed, PathType.Linear, PathMode.Sidescroller2D).SetOptions(true).SetLookAt(0.01f);

        tween.SetEase(Ease.Linear).SetLoops(-1);
    }
}
