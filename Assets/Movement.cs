using UnityEngine;

public class Movement : MonoBehaviour
{
    // Variables
    public float speed = 5f; // The speed of the player
    public float jumpForce = 10f; // The force of the jump
    public string groundTag = "Ground"; // The tag that represents the ground

    private Rigidbody2D rb; // The rigidbody component of the player
    private bool isGrounded; // A flag to indicate if the player is on the ground

    // Start is called before the first frame update
    void Start()
    {
        // Get the rigidbody component
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal input axis
        float horizontal = Input.GetAxis("Horizontal");

        // Move the player based on the input
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        // If the player presses the jump button and is on the ground, apply a jump force
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    // A method that is called when the collider enters contact with another collider
    private void OnCollisionEnter2D(Collision2D other)
    {
        // If the other collider has the tag "Ground"
        if (other.collider.CompareTag(groundTag))
        {
            // Set the flag to true
            isGrounded = true;
        }
    }

    // A method that is called when the collider exits contact with another collider
    private void OnCollisionExit2D(Collision2D other)
    {
        // If the other collider has the tag "Ground"
        if (other.collider.CompareTag(groundTag))
        {
            // Set the flag to false
            isGrounded = false;
        }
    }
}