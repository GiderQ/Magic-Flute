using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;            
    public float smoothTime = 0.1f;       

    private Rigidbody2D rb;
    private Vector2 input;
    private Vector2 currentVelocity;         
    private Vector2 velocityRef;            

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        input = input.normalized;
    }

    void FixedUpdate()
    {
        currentVelocity = Vector2.SmoothDamp(
            currentVelocity,
            input * moveSpeed,
            ref velocityRef,
            smoothTime
        );

        rb.MovePosition(rb.position + currentVelocity * Time.fixedDeltaTime);
    }
}
