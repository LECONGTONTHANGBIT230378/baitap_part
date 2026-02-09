using UnityEngine;

public class PlayerHealth : Health 
{
    protected override void Die() 
    {
        base.Die(); // Gọi lại logic nổ và biến mất của lớp cha [cite: 194]
        Debug.Log("Player died"); // Thông báo riêng của Player [cite: 195]
    }
}