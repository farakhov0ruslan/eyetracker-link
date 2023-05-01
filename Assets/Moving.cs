using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;
    [SerializeField] Sprite sp;
    [SerializeField] private bool roundOrSquare;
    [SerializeField] int maxSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            sr.sprite = sp;
        Vector3 mousePos = Input.mousePosition;
        Vector3 pos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 togo = (pos - transform.position).normalized;
        transform.position = Vector3.Lerp(transform.position, pos, 0.5f * Time.deltaTime);
    }
}
