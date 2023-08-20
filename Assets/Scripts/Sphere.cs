using UnityEngine;

public class Sphere : FallingObject
{
    public override ObjectType ObjectType => ObjectType.Sphere;

    protected override void Explode() => GetComponent<AudioSource>().Play();
}
