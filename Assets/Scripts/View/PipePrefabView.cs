using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePrefabView : MonoBehaviour
{
    private float _speed;
    public float Speed
    {
        set => _speed = value;
    }
    private bool canMove;
    void Update()
    {
        if(!canMove)
            return;
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }

    public void StartMove()
    {
        canMove = true;
    }
}
