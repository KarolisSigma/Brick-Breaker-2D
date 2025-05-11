using UnityEngine;

public class Floor : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ball")){
            GameManager.instance.Lost();
        }
    }
}
