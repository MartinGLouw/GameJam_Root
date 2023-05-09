using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Variables
    public GameObject[] projectiles; // The array of projectile prefabs
    public float shootForce = 10f; // The force of the shooting
    public Transform shootPoint; // The position to shoot from

    private int currentProjectile; // The index of the current projectile
    private Vector2 direction; // The direction of the shooting

    // Start is called before the first frame update
    void Start()
    {
        // Set the current projectile to the first one
        currentProjectile = 0;

        // Set the direction to the right by default
        direction = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        // If the user presses a number key, change the current projectile
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentProjectile = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentProjectile = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentProjectile = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentProjectile = 3;
        }

        // If the user presses the space key, shoot the current projectile
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }

        // If the user presses a movement key, change the direction
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector2.right;
        }
    }

    // A method to shoot the current projectile
    void Shoot()
    {
        // Instantiate the projectile at the shoot point
        GameObject projectile = Instantiate(projectiles[currentProjectile], shootPoint.position, Quaternion.identity);

        // Get the rigidbody component of the projectile
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        // Apply a force to the projectile in the direction of the movement key
        rb.AddForce(direction * shootForce, ForceMode2D.Impulse);
    }
}