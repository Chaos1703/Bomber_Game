using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning_Objects : MonoBehaviour
{
    public GameObject spawn_object;
    public GameObject target;
    public float timer = 0;
    public float spawn_rate = 1f;
    void Update()
    {
        if(timer > spawn_rate){
            Vector3 spawnPosition = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
            Instantiate(spawn_object, spawnPosition, Quaternion.identity);
            timer = 0;
            if(spawn_rate > 0.3)
                spawn_rate = spawn_rate - 0.01f;
            else if(spawn_rate > 0.08)
                spawn_rate = spawn_rate - 0.001f;        
            }
        else
           timer = timer + Time.deltaTime;
    }
}
