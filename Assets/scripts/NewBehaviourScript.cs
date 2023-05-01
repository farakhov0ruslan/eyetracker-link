using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 place = get_position.GetPosition();
        Vector3 spd = (place - transform.position) / 1.5f;
        transform.position += spd * Time.deltaTime;
        Vector3 asd = transform.position;
        asd.z = 0;
        transform.position = asd;
    }
}
