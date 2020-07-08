using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    CharacterController m_jumpcontroller;

    float m_jumpheight = 0.5f;

    float m_gravity = 0.045f;

    bool m_jump = false;

    Vector3 m_movement;

    // Start is called before the first frame update
    void Start()
    {
        m_jumpcontroller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_jump && Input.GetKeyDown(KeyCode.Space))
        {
            m_jump = true;
        }
    }

    private void FixedUpdate()
    {
        if (!m_jumpcontroller.isGrounded)
        {
            m_movement.y -= m_gravity;

        }

        if (m_jump)
        {
            m_movement.y = m_jumpheight;
            m_jump = false;
        }
    }
}
