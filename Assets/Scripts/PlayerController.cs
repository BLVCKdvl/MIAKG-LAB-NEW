using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    private CharacterController controller;

    public void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    
    public void Update()
    {
        //Получаем ввод от игрока
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Направление движение
        Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;

        moveDirection.y = 9.81f * Time.deltaTime;

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);
        
    }
}
