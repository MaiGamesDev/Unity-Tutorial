using JetBrains.Annotations;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject destroyObj;
    public Vector3 pos;
    public Quaternion rot;
    void Start()
    {
        CreateAmongus();

    }


    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.name = "�������!!!!";

        Debug.Log($"ĳ���� �ڽ� ������Ʈ�� �� : {obj.transform.childCount}");
        Debug.Log($"ĳ���� ù��° �ڽ� ������Ʈ�� �̸� : {obj.transform.GetChild(0).name}");
        Debug.Log($"ĳ���� ������ �ڽ� ������Ʈ�� �̸� : {obj.transform.GetChild(obj.transform.childCount-1).name}");
    }


}
