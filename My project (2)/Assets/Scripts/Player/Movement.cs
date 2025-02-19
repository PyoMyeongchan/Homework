using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float moveSpeed = 5.0f;
    Vector3 moveDirection;
    float gravity = -9.81f;

    CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!characterController.isGrounded)
        { // 발이 충돌하면 true, 공중에 떠있으면 false
            moveDirection.y += gravity * Time.deltaTime; // 아래로 떨어지는 중력 적용
        }
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

    public void MoveTo(Vector3 direction)
    {
        // y축은 중력을 적용한다.
        moveDirection = new Vector3(direction.x, moveDirection.y, direction.z);
                

    }
}