using UnityEngine;

public class LevelStateManager : MonoBehaviour
{
    public Player player;
    public LevelGenerator levelGenerator;
    public UIManager uiManager;

    public void GameOver()
    {
        player.Freeze();
        levelGenerator.Freeze();
        uiManager.GameOver();
    }

    public void StartGame()
    {
        player.Unfreeze();
        levelGenerator.Unfreeze();
        uiManager.StartGame();
    }
}
