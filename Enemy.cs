using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool isFrozen = false;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isFrozen)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            // Example enemy movement logic
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
    }
}