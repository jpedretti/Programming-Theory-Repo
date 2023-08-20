using UnityEngine;

public class Sphere : FallingObject
{
    public override ObjectType Type => ObjectType.Sphere;

    public override void Start()
    {
        base.Start();
        FallSpeed = -20;
    }

    protected override void OnTouchGround() => GetComponent<AudioSource>().Play();
}
