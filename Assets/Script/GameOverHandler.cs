using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] private GameOverUI gameOverUI;
    [SerializeField] private StageManager stageManager;
    
    void Awake()
    {
        PlayerLifeTime.OnPlayerDead += GameOver;
        gameOverUI.OnRestart += () =>
        {
            gameOverUI.gameObject.SetActive(false);
            PlayerInputHolder.Unhold();
            stageManager.ReloadCurrent();
        };
    }

    private void GameOver()
    {
        gameOverUI.gameObject.SetActive(true);
        PlayerInputHolder.Hold();
    }
}
