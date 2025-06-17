using UnityEngine;

public class CatController : MonoBehaviour
{
    private Rigidbody2D catRb;
    public float jumpPower = 10f;
    private int jumpCount = 0;

    private bool isGround = false;
    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            catRb.linearVelocityY = 0;
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        jumpCount = 0;
        isGround = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGround = false;
    }
}
