using UnityEngine;

public class LevelStateManager : MonoBehaviour
{
    public Player player;
    public LevelGenerator levelGenerator;

    public void GameOver()
    {
        player.Freeze();
        levelGenerator.Freeze();
    }

    public void StartGame()
    {
        player.Unfreeze();
        levelGenerator.Unfreeze();
    }
}
