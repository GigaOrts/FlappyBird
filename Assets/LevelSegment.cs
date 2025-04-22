using UnityEngine;

public class LevelSegment : MonoBehaviour
{
    private Rigidbody2D body2D;
    public float speed;
    private bool freezed;
    private LevelStateManager _levelStateManager;

    private void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (freezed)
            return;

        body2D.linearVelocityX = speed * Time.fixedDeltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            _levelStateManager.GameOver();
        }
    }

    public void Construct(LevelStateManager levelStateManager)
    {
        _levelStateManager = levelStateManager;
    }

    public void Freeze()
    {
        freezed = true;
        body2D.linearVelocityX = 0f;
    }

    public void Unfreeze()
    {
        freezed = false;
    }
}
