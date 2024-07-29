using UnityEngine;

public class ToggleGameObject : MonoBehaviour
{
    public GameObject targetObject; // GameObject ที่ต้องการเปิด/ปิด

    // ฟังก์ชันนี้จะถูกเรียกเมื่อปุ่มถูกกด
    public void Toggle()
    {
        if (targetObject != null)
        {
            // สลับสถานะการเปิด/ปิดของ GameObject
            targetObject.SetActive(!targetObject.activeSelf);
        }
    }
}

