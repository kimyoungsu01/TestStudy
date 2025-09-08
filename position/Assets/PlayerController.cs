using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    private Vector2 curMovementInput;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move() 
    { 
        Vector3 dir = transform.forward * curMovementInput.y + transform.right * curMovementInput.x;
        dir *= moveSpeed;

        dir.y = _rigidbody.velocity.y;

        _rigidbody.velocity = dir;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Slim"))
        {
            Debug.Log("플레이어 터치");
        }
    }

    public void OnMove(InputAction.CallbackContext context) 
    {
        if (context.phase == InputActionPhase.Performed) 
        { 
          curMovementInput = context.ReadValue<Vector2>();
        }

        else if (context.phase == InputActionPhase.Canceled) 
        { 
          curMovementInput = Vector2.zero;
        }
    }
}
