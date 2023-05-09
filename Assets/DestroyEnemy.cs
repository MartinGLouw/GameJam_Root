using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    // A method that is called when the collider enters contact with another trigger collider
    public string EnemyTag;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the other collider has the tag "Enemy"
        if (other.CompareTag(EnemyTag))
        {
            Debug.Log("Working");
            // Destroy the other object
            Destroy(other.gameObject);

            // Destroy this object
            Destroy(gameObject);
        }
    }
}