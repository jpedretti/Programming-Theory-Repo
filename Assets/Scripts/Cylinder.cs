

using UnityEngine;

public class Cylinder : FallingObject
{
    public override ObjectType ObjectType => ObjectType.Cylinder;

    protected override void Explode() => Destroy(gameObject);
}
