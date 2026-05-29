using UnityEngine;

public class AttackCollision : MonoBehaviour
{
    // ƒeƒXƒg
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit");
        }
    }
}
