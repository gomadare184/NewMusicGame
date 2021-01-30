using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UniRx;
using UniRx.Triggers;
using UnityEditor.Build.Content;
using UnityEngine.UI;

public class SceneMove : MonoBehaviour
{
    [SerializeField] private String Scenename;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.OnClickAsObservable()
            .Subscribe(_ => SceneLoad(Scenename));
    }

    private void SceneLoad(String Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
