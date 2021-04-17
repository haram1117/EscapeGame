using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Setting : MonoBehaviour
{
    BoxCollider2D cam_collider;
    private bool clear = false;
    // Start is called before the first frame update
    void Start()
    {
        cam_collider = GetComponent<BoxCollider2D>();
        //if (!clear)
        //{
        //    cam_collider.size = new Vector2(160, cam_collider.size.y);
        //    cam_collider.offset = new Vector2(30, cam_collider.offset.y);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
