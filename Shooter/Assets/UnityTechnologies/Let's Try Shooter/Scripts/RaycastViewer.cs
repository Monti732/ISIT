using UnityEngine;

public class RaycastViewer : MonoBehaviour {
  public float WeaponRange = 50f;
  private Camera _camera;

  private void Awake() {
    _camera = Camera.main;
  }

  void Update() {
    Vector3 lineOrigin = _camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
    Debug.DrawRay(lineOrigin, _camera.transform.forward * WeaponRange, Color.green);
  }
}