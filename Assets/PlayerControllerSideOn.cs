using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

//AK BOILERPLATE
public class PlayerControllerSideOn : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public float speed = 8f;
    public float jumpingPower = 16f;
    private bool isFacingRight = true;
    private bool isJumping;
    private float jumpTimeCounter;
    public float jumpTime;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {

            if (jumpTimeCounter > 0)
            {
                rb.linearVelocity = Vector2.up * jumpingPower;
                jumpTimeCounter -= Time.deltaTime;

            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {


            if (jumpTimeCounter > 0)
            {
                rb.linearVelocity = Vector2.up * jumpingPower;
                jumpTimeCounter -= Time.deltaTime;

            }
            else
            {
                isJumping = false;
            }

        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            //animator.SetBool("hasJumped", true);
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.linearVelocity = Vector2.up * jumpingPower;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

        Flip();


    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }

    private bool IsGrounded()
    {
        // Debug.Log("HitGround");
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Switch"))
        {
            SceneSwitcher.Instance.CheckAndLoadScene();
           // DontDestroyOnLoad(gameObject);
        }

    }


}


