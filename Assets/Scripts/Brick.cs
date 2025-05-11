using UnityEngine;

public class Brick : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public bool breakable;

    void Start()
    {
        if(!breakable) return;
        health=maxHealth;
        GameManager.instance.UpdateBricks(1);
    }

    public void TakeDamage(int damage){
        if(!breakable) return;
        health-=damage;
        if(health<=0){
            Destroy(gameObject);
            GameManager.instance.UpdateBricks(-1);
        }
    }
}
