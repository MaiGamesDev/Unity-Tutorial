using UnityEngine;

public class StudySomething : MonoBehaviour
{
    public int currentLevel = 10;
    public int maxLevel = 99;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isMax = currentLevel >= maxLevel;
        if (isMax)
        {
            Debug.Log($"���� ������ ������ �ƴմϴ�.");
        }
        else
        {
            Debug.Log($"���� ������ �����Դϴ�.");
        }
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
