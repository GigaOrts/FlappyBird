using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D body2D;
    public Rigidbody2D Rigidbody => body2D;
    public float force;
    public float gravityAcceleration = 1;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            body2D.linearVelocityY = 0;
            body2D.AddForceY(force, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        body2D.linearVelocityY -= gravityAcceleration;
    }
}
