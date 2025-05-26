using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;
    

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        //float localX = transform.eulerAngles.x;
        //float localZ = transform.eulerAngles.z;

        //transform.rotation = Quaternion.Euler(localX, angle, localZ);

        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
