using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorBehaviour : MonoBehaviour
{
    [SerializeField] Sprite cursor;
    [SerializeField] Animation anim;
    [SerializeField] SpriteRenderer sr;

    float minMove = 10;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 wp = TobiiHelper.getWorldPoint();
        if ((transform.position - wp).magnitude > minMove)
        {
            transform.position = wp;
        }
    }
}
