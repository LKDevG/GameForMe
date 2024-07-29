using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase walkableTile;
    public TileBase targetTile;

    void Start()
    {
        // สร้างตารางและตั้งค่าให้เป็น walkable tile
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), walkableTile);
            }
        }

        // ตั้งค่าเป้าหมายในตาราง
        tilemap.SetTile(new Vector3Int(7, 7, 0), targetTile);
    }
}
