using UnityEngine;

public class AiMovement : MonoBehaviour
{
    // Variables
    public float speed = 5f; // The speed of the movement
    public float moveTime = 3f; // The time to move in one direction

    private float timer; // A timer to keep track of the time
    private bool movingRight; // A flag to indicate the direction of the movement

    // Start is called before the first frame update
    void Start()
    {
        // Set the timer to zero
        timer = 0f;

        // Set the direction to left by default
        movingRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Update the timer by adding the delta time
        timer += Time.deltaTime;

        // If the timer exceeds the move time, switch the direction and reset the timer
        if (timer > moveTime)
        {
            movingRight = !movingRight;
            timer = 0f;
        }

        // Move the object based on the direction and speed
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
