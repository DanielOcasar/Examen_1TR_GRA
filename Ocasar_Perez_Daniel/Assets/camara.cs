﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    [SerializeField] Transform playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y + 10, playerPosition.position.z - 15);
    }
}
