using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class FallingObject : MonoBehaviour
{
    public abstract ObjectType ObjectType { get; }
    public bool IsGrounded
    {
        get
        {
            return _isGrounded;
        }
        private set
        {
            _isGrounded = value;
        }
    }

    protected abstract void Explode();

    private bool _isGrounded = false;
    private Rigidbody _rigidBody;

    public virtual void Start() => _rigidBody = GetComponent<Rigidbody>();

    public virtual void Update()
    {
        if (IsGrounded.Not())
        {
            transform.Translate(10 * Time.deltaTime * Vector3.down);
        }
        else if (_rigidBody.useGravity.Not())
        {
            _rigidBody.useGravity = true;
        }
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        IsGrounded = collision.gameObject.CompareTag(Tags.Ground);
        Debug.Log($"{ObjectType} will explode");
        Explode();
    }
}


