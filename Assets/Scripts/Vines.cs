using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vines : MonoBehaviour
{
    public string VineTag;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the other collider has the tag "Enemy"
        if (other.CompareTag(VineTag))
        {
            Debug.Log("Working");
            // Destroy the other object
            Destroy(other.gameObject);

            // Destroy this object
            Destroy(gameObject);
        }
    }
}
