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
            Debug.Log($"현재 레벨은 만렙이 아닙니다.");
        }
        else
        {
            Debug.Log($"현재 레벨은 만렙입니다.");
        }
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
