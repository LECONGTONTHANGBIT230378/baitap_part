using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval = 0.2f;
    public Vector3 bulletOffset;
    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0)) // Nhấn giữ chuột trái để bắn
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        if (bulletPrefabs != null)
        {
            Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);
        }
        else
        {
            Debug.LogError("Vui lòng kéo Prefab viên đạn vào ô Bullet Prefabs trong Inspector!");
        }
    }
}