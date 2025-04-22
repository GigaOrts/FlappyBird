using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D body2D;
    public Rigidbody2D Rigidbody => body2D;
    public float force;
    private bool freezed;

    void Start()
    {
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
        body2D.linearVelocityY = 0;
    }

    public void Unfreeze()
    {
        body2D.bodyType = RigidbodyType2D.Dynamic;
    }
}
