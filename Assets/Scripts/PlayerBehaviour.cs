
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    CharacterController m_charactercontroller;

    float movementSpeed = 5.0f;

    Vector3 m_movement;
    Vector3 m_movementInput;

    float m_horizontalInput;
    float m_verticalInput;

    void RotateCharacterTowardsMouseCursor()
    {
        Vector3 mousepos = Input.mousePosition;
        Vector3 charpos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 direction = mousepos - charpos;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(-angle, Vector3.up);
    }

    // Start is called before the first frame update
    void Start()
    {
        m_charactercontroller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateCharacterTowardsMouseCursor();

        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = Input.GetAxis("Vertical");

        m_movementInput = new Vector3(m_horizontalInput, 0, m_verticalInput);
        
        /*if(m_movementInput != Vector3.zero)
        {
            transform.forward = Quaternion.Euler(0, -90f, 0) * m_movementInput.normalized;
        }*/
        
    }

    private void FixedUpdate()
    {
        m_movement = m_movementInput * movementSpeed * Time.deltaTime;
        m_charactercontroller.Move(m_movement);
    }
}
