using UnityEngine;
using UnityEngine.UI;

public class BlockMove : MonoBehaviour
{
    public string triggerTag;
    public float moveAmount;
    public float resetTime;
    public float moveSpeed;
    public string DirectionSet;
    private Vector3 initialPosition;
    private Vector3 targetPosition;

    void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(triggerTag))
        {
            if (DirectionSet == "Left")
            {
                targetPosition = initialPosition + Vector3.left * moveAmount;
                
            }

            else if (DirectionSet == "Right")
            {
                targetPosition = initialPosition + Vector3.left * moveAmount;
                
            }
        }


    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    
}