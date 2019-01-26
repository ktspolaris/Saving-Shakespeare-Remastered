using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMovement : MonoBehaviour {


    float distance = 10;

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPostion = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPostion;
    }
}