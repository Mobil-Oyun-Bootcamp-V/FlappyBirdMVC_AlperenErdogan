using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerView : MonoBehaviour
{
    public UnityAction OnJump;
    public UnityAction OnDeathCollision;
    public UnityAction OnScore;

    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJump?.Invoke();
        }
    }

    public void Jump(float force)
    {       
        _rigidbody2D.velocity=Vector2.up*force;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Score"))
        {
            OnScore?.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Death"))
        {
            OnDeathCollision?.Invoke();
        }
    }
}
