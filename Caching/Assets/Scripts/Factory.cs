using System;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Factory : MonoBehaviour {
  private Rigidbody _rigidbody;
  public event Action OnSpawn; //опять ничего не передает
  [SerializeField] private GameObject _prefab;

  private void Awake() {
    _rigidbody = GetComponent<Rigidbody>();
  }

  private float _counter = 0f;

  public void Update() {
    _counter += Time.deltaTime;
    if (_counter >= 1f) {
      _prefab = Instantiate(_prefab, new Vector3(0, 0, 0), Quaternion.identity);
      OnSpawn?.Invoke();
      _counter = 0f;
    }
  }
}
