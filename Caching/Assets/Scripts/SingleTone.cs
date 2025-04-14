using UnityEngine;
using UnityEngine.PlayerLoop;

public class SingleTone : MonoBehaviour {
  [SerializeField] private Factory _factory;
  private int _counter = 0;

  private void Start() {
    _factory.OnSpawn += () => Debug.Log(_counter++);
  }
}