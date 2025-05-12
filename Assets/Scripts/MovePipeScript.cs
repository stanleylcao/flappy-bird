using UnityEngine;

public class MovePipeScript : MonoBehaviour
{
    private Camera mainCamera; // Global camera
    private float leftSideX;
    public float moveSpeed = 10;

    private float width;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the collider on this spawned prefab
        Collider2D collider = GetComponentInChildren<BoxCollider2D>();
        if (collider == null)
        {
            Debug.LogError("No Collider2D found on spawned prefab: " + gameObject.name);
            width = 0;
        }
        else
        {
            // Get and store the bounds
            width = collider.bounds.size.x;
        }


        mainCamera = Camera.main;
        float horizontalSize = mainCamera.orthographicSize * mainCamera.aspect;
        leftSideX = mainCamera.transform.position.x - horizontalSize;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x + width / 2 < leftSideX)
        {
            Destroy(gameObject);
        }
    }
}
