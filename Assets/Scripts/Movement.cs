using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 1;
    public static int coinCount = 0;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
