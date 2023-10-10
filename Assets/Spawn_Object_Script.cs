using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Spawn_Object_Script : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player"){
            Time.timeScale = 0;
        }
    }
    public void restart()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
        Time.timeScale = 1;
    }   
}
