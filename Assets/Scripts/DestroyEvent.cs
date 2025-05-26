using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;
    void Start()
    {
        Destroy(gameObject, destroyTime);
        Debug.Log($"{gameObject.name}�� �ı��Ǿ����ϴ�.");
    }

    private void OnDestroy()
    {
        Debug.Log($"{gameObject.name}�� �ı��Ǿ����ϴ�.");
    }
}
