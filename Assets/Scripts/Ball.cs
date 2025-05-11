using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public float startRotation;
    private Rigidbody2D rb;
    private Transform tf;

    void Awake()
    {
        tf=transform;
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        tf.rotation = Quaternion.Euler(0,0, (Random.value*2-1)*20f+startRotation);
        Vector2 forward2D = new Vector2(Mathf.Cos(tf.eulerAngles.z * Mathf.Deg2Rad), Mathf.Sin(tf.eulerAngles.z * Mathf.Deg2Rad));
        rb.velocity = forward2D*speed;
        StartCoroutine(ResetSpeed());
    }

    IEnumerator ResetSpeed(){
        while(true){
            yield return new WaitForSeconds(3);
            rb.velocity = rb.velocity.normalized*speed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Brick")){
            Brick brick = collision.gameObject.GetComponent<Brick>();
            if(brick!=null) brick.TakeDamage(1);
        }
    }
}
