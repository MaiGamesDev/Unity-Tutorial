using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{


    public float moveSpeed = 3f;

    public float returnPosX = 15f;
    public float randomPosY;


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x <= -returnPosX)
        {
            randomPosY = Random.Range(-8f, -2.5f);
            transform.position = new Vector3(returnPosX,randomPosY,0);
        }
    }
}
