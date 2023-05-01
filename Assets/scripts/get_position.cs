using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_position
{
    public static Vector3 GetPosition()
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return position;
    }
}
