using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject GameOverMenu;

    public void GameOver()
    {
        GameOverMenu.SetActive(true);
    }

    public void StartGame()
    {
        GameOverMenu.SetActive(false);
    }
}
