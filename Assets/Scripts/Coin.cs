using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ++Movement.coinCount;
            Debug.Log($"{Movement.coinCount}°³ÀÇ ÄÚÀÎ È¹µæ!");
            Destroy(gameObject);
        }
    }
}
