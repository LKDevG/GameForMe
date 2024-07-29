using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;
using System.Collections.Generic;

public class AIController : MonoBehaviour
{
    public Tilemap tilemap;
    public Transform target;
    public float moveSpeed = 1f;
    public float stepTime = 0.5f; // เวลาที่ใช้ในการขยับแต่ละช่อง

    private Queue<Vector3> path;
    private Vector3Int targetGridPos;

    void Start()
    {
        Vector3Int startGridPos = tilemap.WorldToCell(transform.position);
        targetGridPos = tilemap.WorldToCell(target.position);
        path = new Queue<Vector3>(FindPath(startGridPos, targetGridPos));
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        while (path.Count > 0)
        {
            Vector3 nextPosition = path.Dequeue();
            while (Vector3.Distance(transform.position, nextPosition) > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, nextPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }
            transform.position = nextPosition;
            yield return new WaitForSeconds(stepTime);
        }
    }

    List<Vector3> FindPath(Vector3Int startPos, Vector3Int targetPos)
    {
        List<Vector3> newPath = new List<Vector3>();

        int x = startPos.x;
        int y = startPos.y;

        while (x != targetPos.x || y != targetPos.y)
        {
            if (x < targetPos.x) x++;
            else if (x > targetPos.x) x--;

            if (y < targetPos.y) y++;
            else if (y > targetPos.y) y--;

            newPath.Add(tilemap.CellToWorld(new Vector3Int(x, y, 0)));
        }

        return newPath;
    }
}
