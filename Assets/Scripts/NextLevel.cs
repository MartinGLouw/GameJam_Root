using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string PlayerTag;
    public string SceneSet;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag(PlayerTag))
        {
            SceneManager.LoadScene(SceneSet);
            
        }
    }
}