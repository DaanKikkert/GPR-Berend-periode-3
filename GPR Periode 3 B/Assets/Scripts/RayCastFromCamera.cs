﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastFromCamera : MonoBehaviour
{
    [SerializeField] private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
    }
}
