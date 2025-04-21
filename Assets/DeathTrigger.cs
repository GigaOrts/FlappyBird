using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            player.Rigidbody.linearVelocityY = 0;
            player.transform.position = Vector3.zero;
        }
    }
}
