using UnityEngine;

public class Flipper : MonoBehaviour
{
    private bool facingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && facingRight)
        {
            Flip();
        }
        else if (Input.GetKeyDown(KeyCode.D) && !facingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}