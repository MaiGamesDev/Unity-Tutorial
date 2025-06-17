using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D characterRb;

    public SpriteRenderer[] renderers;    

    public float moveSpeed;
    public float jumpPower;

    private float h;

    private bool isGround;

    private void Start()
    {
        characterRb = GetComponent<Rigidbody2D>();

        renderers = GetComponentsInChildren<SpriteRenderer>(true);
    }
    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        jump();
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = false;
        renderers[0].gameObject.SetActive(false);
        renderers[1].gameObject.SetActive(false);
        renderers[2].gameObject.SetActive(true);
    }
    private void Move()
    {
        if (!isGround)
        {
            return;
        }
        


        if (h != 0)
        {
            renderers[0].gameObject.SetActive(false);
            renderers[1].gameObject.SetActive(true);
            renderers[2].gameObject.SetActive(false);
            characterRb.linearVelocityX = h * moveSpeed;

            if (h > 0)
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
                renderers[2].flipX = false;
            }
            else if (h < 0)
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
                renderers[2].flipX = true;
            }
        }
        else
        {
            renderers[0].gameObject.SetActive(true);
            renderers[1].gameObject.SetActive(false);
            renderers[2].gameObject.SetActive(false);
        }
    }
    void jump()
    {

        if (Input.GetButtonDown("Jump") && isGround) 
        {
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }
    
   
}
