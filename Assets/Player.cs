using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D body2D;
    private Vector3 startPosition;
    public Rigidbody2D Rigidbody => body2D;
    public float force;
    private bool freezed;

    void Start()
    {
        startPosition = transform.position;
        body2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (freezed)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            body2D.linearVelocityY = 0;
            body2D.AddForceY(force, ForceMode2D.Impulse);
        }
    }

    public void Freeze()
    {
        body2D.bodyType = RigidbodyType2D.Kinematic;
        body2D.linearVelocity = Vector2.zero;
        body2D.angularVelocity = 0f;
    }

    public void Unfreeze()
    {
        body2D.bodyType = RigidbodyType2D.Dynamic;
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
    }
}
