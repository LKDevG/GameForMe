using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase walkableTile;
    public TileBase targetTile;

    void Start()
    {
        // ���ҧ���ҧ��е�駤������� walkable tile
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), walkableTile);
            }
        }

        // ��駤���������㹵��ҧ
        tilemap.SetTile(new Vector3Int(7, 7, 0), targetTile);
    }
}
