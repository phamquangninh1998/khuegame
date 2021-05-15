using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
     Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateRotation();

    }

    private void UpdateRotation()
    {
        Vector2 pos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = new Vector2(mousePos.x - pos.x, mousePos.y - pos.y);
        transform.rotation = Quaternion.FromToRotation(Vector2.right, dir);
    }
}
