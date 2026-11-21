using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour


{
    public FixedJoystick joystick;
    private Animator animator;
    private float moveSpeed = 7f;
    private bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = joystick.Horizontal;
        float y = joystick.Vertical;

        Vector3 moveDirection = new Vector3(x, 0, y); // Assuming movement in the X-Z plane

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Change character's direction based on movement
        if (x > 0 && !facingRight)
        {
            Flip();
        }
        else if (x < 0 && facingRight)
        {
            Flip();
        }

        // Assuming you have a parameter "waiwai" in your Animator controller
        animator.SetBool("waiwai", (x != 0.0f || y != 0.0f));
    }

    // Method to flip the character's direction left or right
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}