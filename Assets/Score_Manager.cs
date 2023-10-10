using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    public Text Score;
    public int score = 0;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Score.text = score.ToString();
        Destroy(other.gameObject);
    }
}
