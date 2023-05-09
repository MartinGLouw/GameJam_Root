using UnityEngine;

public class LeafLift : MonoBehaviour
{
    public string triggerTag;
    public float moveAmount;
    public float resetTime;
    public float moveSpeed;

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
            targetPosition = initialPosition + Vector3.up * moveAmount;
            CancelInvoke(nameof(ResetPosition));
            Invoke(nameof(ResetPosition), resetTime);
        }
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    void ResetPosition()
    {
        targetPosition = initialPosition;
    }
}