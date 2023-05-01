using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;
using static UnityEditor.PlayerSettings;

public class CharacterBehaviour : MonoBehaviour
{
    [SerializeField] public SpriteRenderer sr;
    [SerializeField] public Sprite square;
    [SerializeField] public Sprite circle;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
        sr.sprite = square;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 0) sr.sprite = circle;
        else sr.sprite = square;
        GazePoint gp = TobiiAPI.GetGazePoint();
        if (gp.IsValid)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(gp.Screen);
            transform.position = Vector2.Lerp(transform.position, pos, 0.1f * Time.deltaTime);
            Debug.Log(pos.ToString());
        }
    }
}
