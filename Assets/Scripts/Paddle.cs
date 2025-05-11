using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private float width;
    private float yPos;
    public Vector2 borders;
    private Vector2 minMaxX;
    private float mousePos;
    private Transform tf;
    private Camera cam;
 
    void Start()
    {
        cam = Camera.main;
        tf = transform;
        yPos = tf.position.y;
        width = tf.localScale.x/2f;
        minMaxX = new Vector2(borders.x+width, borders.y-width);
    }

    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0,0)).x;
        
        if(mousePos<minMaxX.x || mousePos>minMaxX.y) return;
        tf.position = new Vector3(mousePos, yPos, 0);
    }
}
