using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    [SerializeField] private float _speed = 10;

    private void OnCollisionStay(Collision collision) {
        collision.rigidbody.AddForce(Vector3.left * _speed);
    }

}
