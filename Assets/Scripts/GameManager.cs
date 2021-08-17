﻿#define DEBUG_KEY

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TinyAudio.PlaySE(TinyAudio.SE.Decision);
    }

    // Update is called once per frame
    void Update()
    {
#if DEBUG_KEY
        if(Input.GetKeyDown(KeyCode.O))
        {
            TinyAudio.BGM bgm = TinyAudio.BGM.Gameover;
            SceneManager.LoadScene("Gameover");
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            TinyAudio.BGM bgm = TinyAudio.BGM.Clear;
            SceneManager.LoadScene("Clear");
        }
#endif

    }
}