using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour
{
    float distance = 10;
    Vector3 dist;
    float posX, posY;
    private void Start()
    {
        
    }
    void OnMouseDrag()
    {
        Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = objPosition;
    }

    private void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }
}
