using System.Collections;
using System.Text.RegularExpressions;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public PinballManager pinballManager;
    private void OnCollisionEnter2D(Collision2D other)
    {
        int score = 0;
        switch (other.gameObject.tag)
        {
            case "Score10":
                score = 10;
                break;
            case "Score30":
                score = 30;
                break;
            case "Score50":
                score = 50;
                break;
        }
        if (score != 0)
        {
            pinballManager.totalScore += score;
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            Debug.Log("게임오버");
        }
    }
}
