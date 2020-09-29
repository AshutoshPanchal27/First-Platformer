using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    Rigidbody m_rigidbody;
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_rigidbody.AddForce(new Vector3(100f, 1000f, 0));
        }
    }
}
