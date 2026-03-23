using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    public int damage; 

    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Tìm component EnemyHealth trên đối tượng va chạm
        var enemy = collision.GetComponent<EnemyHealth>();
        
        if (enemy != null)
        {
            // Gây sát thương nếu tìm thấy EnemyHealth
            enemy.TakeDamage(damage);
        }

        // Hủy viên đạn sau khi va chạm
        Destroy(gameObject);
    }
}