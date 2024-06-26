using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class FlyingBehavior : MonoBehaviour
{
  [SerializeField] private float _velocity = 1.5f;
  [SerializeField] private float _rotationSpeed = 10f;

  private Rigidbody2D _rb;

  private void Start()
  {
    _rb = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      _rb.velocity = Vector2.up * _velocity;
       
    }
  } 
  private void FixedUpdate()
  {
    transform.rotation = Quaternion.Euler(0,0, _rb.velocity.y * _rotationSpeed);
  }
}
