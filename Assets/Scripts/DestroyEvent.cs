using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;
    void Start()
    {
        Destroy(gameObject, destroyTime);
        Debug.Log($"{gameObject.name}이 파괴되었습니다.");
    }

    private void OnDestroy()
    {
        Debug.Log($"{gameObject.name}이 파괴되었습니다.");
    }
}
