using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spavn : MonoBehaviour {
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnPoint;

    private void Start() {
        Instantiate(_template, _spawnPoint.position, Quaternion.identity);
    }
}
