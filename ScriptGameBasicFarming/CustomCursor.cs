using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D cursorTexture; // รูปภาพของเคอร์เซอร์ใหม่
    public Vector2 hotSpot = Vector2.zero; // จุดที่เป็นจุดคลิกของเคอร์เซอร์
    public CursorMode cursorMode = CursorMode.Auto;

    void Start()
    {
        ChangeCursor(cursorTexture);
    }

    public void ChangeCursor(Texture2D newCursorTexture)
    {
        if (newCursorTexture != null)
        {
            Cursor.SetCursor(newCursorTexture, hotSpot, cursorMode);
        }
        else
        {
            Cursor.SetCursor(null, Vector2.zero, cursorMode);
        }
    }
}