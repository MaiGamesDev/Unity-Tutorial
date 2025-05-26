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
        obj.name = "어몽구스!!!!";

        Debug.Log($"캐릭터 자식 오브젝트의 수 : {obj.transform.childCount}");
        Debug.Log($"캐릭터 첫번째 자식 오브젝트의 이름 : {obj.transform.GetChild(0).name}");
        Debug.Log($"캐릭터 마지막 자식 오브젝트의 이름 : {obj.transform.GetChild(obj.transform.childCount-1).name}");
    }


}
