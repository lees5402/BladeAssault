using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private float horizontal;

    private Animator _anim;
    private Rigidbody2D _rigid;
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        _rigid= GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Move();
        Flip();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }

    private void Move()
    {
        _rigid.velocity = new Vector2(horizontal * moveSpeed, _rigid.velocity.y);

        if (_rigid.velocity != Vector2.zero)
            _anim.SetBool(AnimationHash.Run, true);
        else
            _anim.SetBool(AnimationHash.Run, false);
    }

    private void Flip()
    {
        if(horizontal < 0)
            _spriteRenderer.flipX = true;
        
        else
            _spriteRenderer.flipX = false;
    }

}
