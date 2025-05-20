using UnityEngine;

public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("start");
        Debug.LogWarning("sex");
        Debug.LogError("orral");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
    }
}
