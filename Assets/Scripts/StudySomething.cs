using UnityEngine;

public class StudySomething : MonoBehaviour
{
    public int currentLevel = 10;
    public int maxLevel = 99;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isMax = currentLevel >= maxLevel;
        Debug.Log($"현재 레벨은 만렙이 {isMax}입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
