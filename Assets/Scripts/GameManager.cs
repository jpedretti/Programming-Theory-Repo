using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<FallingObject> _fallingObjects;

    void Start()
    {
        foreach (var fallingObject in _fallingObjects)
        {
            fallingObject.ChangeColor(Random.ColorHSV());
        }
    }
}
