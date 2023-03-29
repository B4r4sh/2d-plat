using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using DG.Tweening;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _playerRigedBody;
    private Animator _playerAnimator;
    private Transform _playerTransform;

    private bool isPlayerMoveRight;
    private bool isGroundUnderFeet = true;
    private bool isPlayerRun = false;

    private float _rayDistance;
    void Start()
    {
        _playerRigedBody = GetComponent<Rigidbody2D>();
        _rayDistance = 1f; 
        _playerAnimator = GetComponent<Animator>();
        _playerTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        //// Движение влево и вправо \\\\
        if (Input.GetKey(KeyCode.D))
        {
            if (isPlayerMoveRight)
            {
                RotatePlayer();
            }

            _playerAnimator.SetBool("isRun", true);
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (!isPlayerMoveRight)
            {
                RotatePlayer();
            }

            _playerAnimator.SetBool("isRun", true);
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        else
        {
            _playerAnimator.SetBool("isRun", false);
        }

        //// Прыжок \\\\
        if (Input.GetKey(KeyCode.Space))
        {
            IsThereGroundUnderFeet();

            if (isGroundUnderFeet)
            {
                _playerRigedBody.velocity = new Vector2(_playerRigedBody.velocity.x, _jumpForce);
            }
        }
    }


    private void RotatePlayer()
    {
        isPlayerMoveRight = !isPlayerMoveRight;
        transform.Rotate(0,180,0);
    }

    private void IsThereGroundUnderFeet()
    {
        RaycastHit2D hit = Physics2D.Raycast(_playerRigedBody.position, Vector2.down, _rayDistance, LayerMask.GetMask("Ground"));

        if (hit.collider == true)
        {
            isGroundUnderFeet = true;
        }
        else
        {
            isGroundUnderFeet=false;
        }
    }
}
