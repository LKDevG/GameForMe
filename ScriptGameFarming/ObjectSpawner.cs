using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ObjectSpawner : MonoBehaviour
{
    [System.Serializable]
    public struct SpawnInfo
    {
        public GameObject objectToSpawn;
        public Tilemap tilemap;
        public int spawnCount;
        public float spawnChance; // โอกาสการเกิดในแต่ละครั้ง (0-100)
    }

    public List<SpawnInfo> spawnInfos;

    void Start()
    {
        SpawnObjectsOnTiles();
    }

    void SpawnObjectsOnTiles()
    {
        foreach (var spawnInfo in spawnInfos)
        {
            List<Vector3Int> possibleSpawnLocations = GetAllTilePositions(spawnInfo.tilemap);
            for (int i = 0; i < spawnInfo.spawnCount; i++)
            {
                if (Random.Range(0f, 100f) <= spawnInfo.spawnChance)
                {
                    if (possibleSpawnLocations.Count > 0)
                    {
                        int index = Random.Range(0, possibleSpawnLocations.Count);
                        Vector3Int spawnLocation = possibleSpawnLocations[index];
                        possibleSpawnLocations.RemoveAt(index);

                        Vector3 place = spawnInfo.tilemap.CellToWorld(spawnLocation);
                        Instantiate(spawnInfo.objectToSpawn, place, Quaternion.identity);
                    }
                }
            }
        }
    }

    List<Vector3Int> GetAllTilePositions(Tilemap tilemap)
    {
        List<Vector3Int> positions = new List<Vector3Int>();
        BoundsInt bounds = tilemap.cellBounds;

        for (int x = bounds.xMin; x < bounds.xMax; x++)
        {
            for (int y = bounds.yMin; y < bounds.yMax; y++)
            {
                Vector3Int localPlace = new Vector3Int(x, y, (int)tilemap.transform.position.y);
                if (tilemap.HasTile(localPlace))
                {
                    positions.Add(localPlace);
                }
            }
        }

        return positions;
    }
}