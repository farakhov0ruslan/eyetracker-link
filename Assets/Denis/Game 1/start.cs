using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        star.money = 0;
        star.life = 3;
        spawner.spawnRate = 2f;
        spawner.restart = Time.time / spawner.speedUp;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
