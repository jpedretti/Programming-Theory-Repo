using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class FallingObject : MonoBehaviour // INHERITANCE
{
    public abstract ObjectType Type { get; }
    public bool IsGrounded { get; private set; } = false;
    public float FallSpeed // ENCAPSULATION
    {
        get { return _fallSpeed; }
        protected set
        {
            if (value >= 0)
            {
                Debug.LogError("FallSpeed must be negative, it's falling after all.");
                return;
            }
            Debug.Log($"{gameObject.name} {Type} set fall speed to {value}");
            _fallSpeed = value;
        }
    }

    protected abstract void OnTouchGround(); // POLYMORPHISM

    private Rigidbody _rigidBody;
    private float _fallSpeed = -10;

    public virtual void Start() => _rigidBody = GetComponent<Rigidbody>();

    public virtual void Update()
    {
        if (IsGrounded.Not())
        {
            transform.Translate(FallSpeed * Time.deltaTime * Vector3.up);
        }
        else if (_rigidBody.useGravity.Not())
        {
            _rigidBody.useGravity = true;
        }
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        IsGrounded = collision.gameObject.CompareTag(Tags.Ground);
        Debug.Log($"{gameObject.name} {Type} touched ground");
        OnTouchGround();
    }

    public void ChangeColor(Color newColor) => GetComponent<Renderer>().material.color = newColor; // ABSTRACTION
}
