using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
public GameObject bulletPrefabs;
public float shootingInterval;
private float lastBulletTime;
void Update()
{
if (Input.GetMouseButton(0))
{
if (Time.time - lastBulletTime >
shootingInterval)
{
ShootBullet();
lastBulletTime = Time.time;
}
}
}
public Vector3 bulletOffset;
private void ShootBullet()
{
Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);
}
}
