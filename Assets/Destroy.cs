using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Variables
    public float lifeTime = 5f; // The time to destroy the prefab

    // Start is called before the first frame update
    void Start()
    {
        // Destroy the prefab after the life time
        Destroy(gameObject, lifeTime);
    }
}