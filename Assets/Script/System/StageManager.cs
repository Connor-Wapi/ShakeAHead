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
    
    void Start()
    {
        SceneManager.LoadScene(_currentStage + 1, LoadSceneMode.Additive);
    }

    public void LoadNext()
    {
        LoadStage(_currentStage + 1);
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
