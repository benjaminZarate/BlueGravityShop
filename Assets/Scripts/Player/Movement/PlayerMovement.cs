using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private PlayerMovementData playerMovementData;

    private Rigidbody2D rigidbody2D;
    private Vector2 movementInput;
    private Animator anim;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = movementInput * playerMovementData.Speed;
    }

    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
        anim.SetBool("Walk", inputValue.Get<Vector2>().x != 0 || inputValue.Get<Vector2>().y != 0);
        if (inputValue.Get<Vector2>().x < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        else if(inputValue.Get<Vector2>().x > 0) 
        {
            transform.localScale = new Vector2(1, 1);
        }
    }
}
