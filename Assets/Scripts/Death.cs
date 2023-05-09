using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public string DeathTag;
    public string SceneSet;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Dead");
        if (other.CompareTag(DeathTag))
        {
            SceneManager.LoadScene(SceneSet);
            
        }
    }
}