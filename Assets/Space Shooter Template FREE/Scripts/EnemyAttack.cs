using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth health; // Tham chiếu đến script máu của chính kẻ địch
    public int damage;         // Sát thương gây ra cho người chơi

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem vật va chạm có phải là người chơi không
        var playerHealth = collision.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            // Gây sát thương cho người chơi
            playerHealth.TakeDamage(damage);

            // Kẻ địch tự sát bằng cách tự trừ một lượng máu rất lớn
            if (health != null)
            {
                health.TakeDamage(1000);
            }
        }
    }
}