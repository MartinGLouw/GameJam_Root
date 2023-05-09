using UnityEngine;

public class ActiveInView : MonoBehaviour
{
    // A method that is called when the renderer becomes visible to any camera
    private void OnBecameVisible()
    {
        // Activate the game object
        gameObject.SetActive(true);
    }

    // A method that is called when the renderer becomes invisible to all cameras
    private void OnBecameInvisible()
    {
        // Deactivate the game object
        gameObject.SetActive(false);
    }
}