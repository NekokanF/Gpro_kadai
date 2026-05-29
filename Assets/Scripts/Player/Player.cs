using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jump_P;
    [SerializeField] Animator animator;

    public bool OnAttack = false;

    PlayerInput playerInput;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        // à⁄ìÆ
        var move = playerInput.actions["Move"].ReadValue<Vector2>();
        if (move.x != 0f)
        {
            animator.SetBool("1_Move", true);
            rb.linearVelocityX = move.x * speed;

            var scale = transform.localScale;
            if (move.x > 0f)
            {
                scale.x = 1f;
            }
            else
            {
                scale.x = -1f;
            }
            transform.localScale = scale;
        }
        else if (move.x == 0)
        {
            rb.linearVelocityX = 0f;
            animator.SetBool("1_Move", false);
        }

        // çUåÇ
        if (!OnAttack)
        {
            if (playerInput.actions["Attack"].WasPressedThisFrame())
            {
                animator.SetTrigger("2_Attack");
            }
        }
        
    }
}
