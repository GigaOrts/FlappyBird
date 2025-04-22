using UnityEngine;

public class LevelDestroyer : MonoBehaviour
{
    public LevelGenerator levelGenerator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out LevelSegment levelSegment))
        {
            levelGenerator.LevelSegments.Remove(levelSegment);
            Destroy(collision.gameObject);
        }
    }
}
