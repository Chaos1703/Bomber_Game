using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Movement : MonoBehaviour
{
    public int score = 0;
    public float movespeed = 20f;
    public GameObject game_over;
    private void Start()
    {
        game_over.SetActive(false);
    }
    void Update()
    {
        if(Time.timeScale == 0){
            game_over.SetActive(true);
        }
        float movement = movespeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -14.45)
        {
            transform.Translate(Vector2.left * movement);
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 14.57)  
        {
            transform.Translate(Vector2.right * movement);
        }
    }
}
