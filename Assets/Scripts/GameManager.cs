using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<FallingObject> _fallingObjects; // POLYMORPHISM

    void Start()
    {
        foreach (var fallingObject in _fallingObjects)
        {
            fallingObject.ChangeColor(Random.ColorHSV()); // ABSTRACTION
        }
    }
}
