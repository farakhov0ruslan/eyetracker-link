using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TobiiCursorBehaviour : MonoBehaviour
{
    [SerializeField] float mass;
    private static Vector3 wp;

    public static Vector3 world_point
    {
        get { return wp; }
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        wp = TobiiHelper.getWorldPoint();
        transform.position += (wp - transform.position).sqrMagnitude * (wp - transform.position).normalized / mass;
        transform.position.Set(transform.position.x, transform.position.y, 0);
    }
}
