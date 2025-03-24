using System;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour {
  public int score;
  public string name;
  public double damage;
  public int[,] coordinates;
  public UltraString text;
  public Dictionary<string, string> dictionary;
  public List<string> coolStrings;

  void Start() {
    score = 500;
    name = "obekt";
    damage = 1000000000.1;
    coordinates = new int[,] { { 1, 1 } };
    dictionary = new Dictionary<string, string>();
    dictionary.Add("key", "value");
    coolStrings = new List<string>() {"aaaa", "bbbbbb", "ccccc"};
    text = new UltraString("ultra text");

    Debug.Log(score);
    Debug.Log(name);
    Debug.Log(damage);
    Debug.Log(coordinates);
    Debug.Log(text);
    Debug.Log(coolStrings);
    Debug.Log(dictionary);
    foreach (var item in coolStrings) {
      Console.WriteLine(item);
    }
  }

  void Update() { }
}

public class UltraString {
  private string text;

  public UltraString(string text) {
    this.text = text;
  }
}