using UnityEngine;

public class Cube : FallingObject
{
    public override ObjectType ObjectType => ObjectType.Cube;

    protected override void Explode() => GetComponent<ParticleSystem>().Play();
}
