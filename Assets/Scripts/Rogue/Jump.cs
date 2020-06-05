using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class Jump : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    readonly Vector2 force = new Vector2(0, 10);

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {  
            m_Rigidbody.AddForce(force);
        }
    }
}
