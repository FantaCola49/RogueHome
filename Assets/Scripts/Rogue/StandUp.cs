using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandUp : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
            transform.rotation = Quaternion.Euler(Vector3.zero);
    }
}
