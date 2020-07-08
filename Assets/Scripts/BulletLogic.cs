using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    Rigidbody m_bullet;

    float m_bulletSpeed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        m_bullet = GetComponent<Rigidbody>();
        if (m_bullet)
        {
            m_bullet.velocity = transform.up * m_bulletSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
