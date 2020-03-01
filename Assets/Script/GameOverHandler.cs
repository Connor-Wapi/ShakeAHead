using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] private GameOverUI gameOverUI;
    [SerializeField] private GameObject clearUI;
    [SerializeField] private GameObject ringUI;
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
        Clear.OnClear += () =>
        {
            ringUI.SetActive(false);
            clearUI.SetActive(true);
        };
    }

    private void GameOver()
    {
        gameOverUI.gameObject.SetActive(true);
        PlayerInputHolder.Hold();
    }
}
