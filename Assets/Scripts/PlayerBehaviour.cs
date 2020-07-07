using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    CharacterController m_charactercontroller;

    float movementSpeed = 5.0f;

    Vector3 m_movement;

    float m_horizontalInput;

    float m_jumpheight = 0.5f;

    float m_gravity = 0.045f;

    bool m_jump = false;

    // Start is called before the first frame update
    void Start()
    {
        m_charactercontroller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");

        if (!m_jump && Input.GetKeyDown(KeyCode.Space))
        {
            m_jump = true;
        }
    }

    private void FixedUpdate()
    {
        if (!m_charactercontroller.isGrounded)
        {
            m_movement.y -= m_gravity;

        }

        if (m_jump)
        {
            m_movement.y = m_jumpheight;
            m_jump = false;
        }

        m_movement.x = m_horizontalInput * movementSpeed * Time.deltaTime;
        m_charactercontroller.Move(m_movement);
    }
}
