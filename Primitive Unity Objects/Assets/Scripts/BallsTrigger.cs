using UnityEngine;

public class BallsTrigger : MonoBehaviour {
  private void OnTriggerEnter(Collider other) {
    if (other.CompareTag("YellowBall")) {
      Debug.Log(other.name);
    }
  }
}