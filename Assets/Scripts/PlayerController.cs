using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject playerRef;
    public float moveSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!playerRef)
        {
            Debug.LogError("No Player ref");
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Movement
        Vector3 newPos = playerRef.transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            newPos.y = playerRef.transform.position.y + (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPos.y = playerRef.transform.position.y - (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            newPos.x = playerRef.transform.position.x + (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            newPos.x = playerRef.transform.position.x - (moveSpeed * Time.deltaTime);
        }

        playerRef.transform.SetPositionAndRotation(newPos, playerRef.transform.rotation);
    }
}
