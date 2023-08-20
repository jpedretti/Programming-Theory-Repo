using UnityEngine;

public class Cube : FallingObject
{
    public override ObjectType Type => ObjectType.Cube;

    protected override void OnTouchGround() => GetComponent<ParticleSystem>().Play();
}
