using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TobiiButtonBehaviour : MonoBehaviour
{
    private RectTransform rt;
    private Button bt;
    private Canvas cv;
    private float timeOnFocus = 0;
    [SerializeField] float focusTime;
    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<RectTransform>();
        bt = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3[] corners = new Vector3[4];
        rt.GetWorldCorners(corners);
        Vector3 bot_left = Camera.main.ScreenToWorldPoint(corners[0]);
        Vector3 top_right = Camera.main.ScreenToWorldPoint(corners[2]);
        Vector3 wp = TobiiCursorBehaviour.world_point;
        //if you want you can use direct sight on the button but it will shake and may cause a misclick
        //against it using cursor will improve stability
        //Vector3 wp = TobiiHelper.getWorldPoint();
        if (wp.y >= bot_left.y && wp.y <= top_right.y && wp.x >= bot_left.x && wp.x <= top_right.x)
        {
            timeOnFocus += Time.deltaTime;
        }
        else timeOnFocus = 0;

        if (timeOnFocus >= focusTime)
        {
            bt.onClick.Invoke();
            timeOnFocus = 0;
        }
    }
}
