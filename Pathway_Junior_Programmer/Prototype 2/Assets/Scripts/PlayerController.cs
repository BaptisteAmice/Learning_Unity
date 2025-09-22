using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 10.0f;
    private float xRange = 10.0f;
    public GameObject projectilePrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Launch a projectile from the player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch the projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}