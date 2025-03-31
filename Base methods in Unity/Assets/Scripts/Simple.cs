using System;
using UnityEngine;

[Serializable]
public class Simple : MonoBehaviour {
  private void OnDisable() {
    Debug.Log("OnDisable");
  }

  private void FixedUpdate() {
    Debug.Log("FixedUpdate");
    Destroy(this);
  }

  private void LateUpdate() {
    Debug.Log("LateUpdate");
    Destroy(this);
  }


  private void OnDestroy() {
    Debug.Log("OnDestroy");
  }

  private void Update() {
    Debug.Log("Update");
    Destroy(this);
  }

  private void Start() {
    Debug.Log("Start");
  }

  private void OnEnable() {
    Debug.Log("OnEnable");
  }

  private void Awake() {
    Debug.Log("Awake");
  }
}