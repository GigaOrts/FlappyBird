using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public LevelStateManager levelStateManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            levelStateManager.GameOver();
        }
    }
}
