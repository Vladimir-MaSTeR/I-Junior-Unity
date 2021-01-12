using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    [SerializeField] private float _speed = 5;
    private Rigidbody _rigidbody;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update() {
        _rigidbody.AddForce(Vector3.left * _speed);
    }

}
