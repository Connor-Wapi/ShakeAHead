﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public static StageManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<StageManager>();
            }
            return _instance;
        }
    }

    private static StageManager _instance;

    private int _currentStage = 0;

    public event Action OnLoadNext;
    
    void Start()
    {
        SceneManager.LoadScene(_currentStage + 1, LoadSceneMode.Additive);
    }

    public void LoadNext()
    {
        OnLoadNext?.Invoke();
        LoadStage(_currentStage + 1);
    }

    public void ReloadCurrent()
    {
        LoadStage(_currentStage);
    }

    private void LoadStage(int stage)
    {
        StartCoroutine(LoadStageCoroutine(stage));
    }

    private IEnumerator LoadStageCoroutine(int stage)
    {
        yield return 
            SceneManager.UnloadSceneAsync(_currentStage + 1);
        _currentStage = stage;
        SceneManager.LoadScene(_currentStage + 1, LoadSceneMode.Additive);
    }
}
