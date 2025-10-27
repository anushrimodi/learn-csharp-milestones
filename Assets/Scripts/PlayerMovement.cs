using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    public float jumpForce = 6f;

    [Header("Ground Check")]
    public LayerMask groundLayer;
    private bool isGrounded;

    [Header("Shooting Settings")]
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float projectileSpeed = 10f;

    private Rigidbody rb;

    void Start()
    {
        // Cache Rigidbody component
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.useGravity = true;
    }

    void FixedUpdate()
    {
        // Capture movement input
        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        // Move forward/backward
        Vector3 movement = transform.forward * move * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotate left/right
        Quaternion turnRotation = Quaternion.Euler(0f, turn * rotationSpeed * Time.fixedDeltaTime, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);

        // Ground check via raycast
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f, groundLayer);
    }

    void Update()
    {
        // Jump
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.Log("Jumped!");
        }

        // Shoot (Left Mouse Button)
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (projectilePrefab != null && firePoint != null)
        {
            GameObject bullet = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.linearVelocity = firePoint.forward * projectileSpeed;
            Destroy(bullet, 3f); // auto-remove after 3 seconds
            Debug.Log("Shot fired!");
        }
        else
        {
            Debug.LogWarning("Missing Projectile Prefab or FirePoint!");
        }
    }

    // --- COLLISIONS AND TRIGGERS ---
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger: " + other.name);

        // Collect cubes (items)
        if (other.CompareTag("Cube"))
        {
            Destroy(other.gameObject);
            Debug.Log("Cube collected!");
            
            // Add to GameManager item count
            if (GameManager.Instance != null)
                GameManager.Instance.Items++;
        }

        // Health pickup example
        if (other.CompareTag("Health"))
        {
            Destroy(other.gameObject);
            if (GameManager.Instance != null)
                GameManager.Instance.Health++;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited trigger: " + other.name);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);

        // Example: lose health if colliding with "Obstacle"
        if (collision.gameObject.CompareTag("Obstacle") && GameManager.Instance != null)
        {
            GameManager.Instance.Health--;
            Debug.Log("Ouch! Health now: " + GameManager.Instance.Health);
        }
    }
}
