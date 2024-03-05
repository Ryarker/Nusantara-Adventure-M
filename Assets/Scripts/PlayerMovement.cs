using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private float jumpPower;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] public Rigidbody2D rb;
    public float knockBackForce;
    public float knockBackCounter;
    public float knockBackTotalTime;

    PlayerControl controls;

    [Header("Transform")]
    private float direction = 0f;
    private float speed = 5f;
    private Vector2 directionalInput;

    [Header("Boolean")]
    private bool isFacingRight = true;
    public bool knockFromRight;


    [Header("References")]
    public static PlayerMovement Instance;


    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();

        controls = new PlayerControl();
        controls.Enable();

        controls.Ground.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
            SetDirectionalInput(new Vector2(direction, 0f));
        };
        controls.Ground.Jumping.performed += ctx => Jumping();
    }
    void Update()
    {
        // horizontal = Input.GetAxisRaw("Horizontal");

        Jumping();
        PlayerManager.Instance.animPlayer.SetBool("isGrounded", isGrounded());
        SetDirectionalInput(new Vector2(direction, 0f));
    }

    private void FixedUpdate()
    {
        if(knockBackCounter <= 0)
        {
            rb.velocity = new Vector2(direction * speed, rb.velocity.y);
        }
        else
        {
            if(knockFromRight == true)
            {
                rb.velocity = new Vector2(-knockBackForce, knockBackForce);
            }
            if(knockFromRight == false)
            {
                rb.velocity = new Vector2(knockBackForce, knockBackForce);
            }

            knockBackCounter -=Time.deltaTime;
        }



    }
    void PlayJumpAnimation()
    {
        PlayerManager.Instance.animPlayer.SetTrigger("jump");
    }
    public void SetDirectionalInput(Vector2 input)
    {
        directionalInput = input;
    PlayerManager.Instance.animPlayer.SetFloat("speed", Mathf.Abs(input.x));

    if (input.x < 0)
    {
        // Hadap kiri
        Flip(false);
    }
    else if (input.x > 0)
    {
        // Hadap kanan
        Flip(true);
    }
        

    }
    public bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }


    private void Flip(bool faceRight)
{
    if (faceRight != isFacingRight)
    {
        isFacingRight = faceRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}

    private void Jumping () {
        if (controls.Ground.Jumping.triggered && isGrounded()) // Check if jump action is triggered
    {
        PlayJumpAnimation();
        AudioManager.Instance.Play("Jump");
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
    }
    if (controls.Ground.Jumping.triggered && rb.velocity.y > 0f) // Check if jump action is triggered
    {
        PlayJumpAnimation();
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
    }
    }

     private void OnEnable() {
        controls.Enable();
    }
    private void OnDisable() {
        controls.Disable();
    }
}