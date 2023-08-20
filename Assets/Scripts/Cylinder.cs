public class Cylinder : FallingObject
{
    public override ObjectType Type => ObjectType.Cylinder;

    protected override void OnTouchGround() => Destroy(gameObject);
}
