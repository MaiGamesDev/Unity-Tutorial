using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
        if (transform.position.x <= -30f)
        {
            transform.position += new Vector3(60f,0,0);
        }
    }
}
