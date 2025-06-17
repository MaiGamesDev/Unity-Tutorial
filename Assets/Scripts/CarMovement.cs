using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 50f;

    public Rigidbody2D carRb;

    private float h;

    void Update()
    {
        h = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        carRb.linearVelocityX = h * moveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision enter");
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("collision stay");
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("collision exit");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger enter");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Trigger stay");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Trigger exit");
    }


}
