using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetAstar : MonoBehaviour
{
    //private AStar aStar;

    [SerializeField] private NPCPath npcPath = null;
    [SerializeField] private bool moveNPC = false;
    [SerializeField] private bool follwerPlayer = false;
    [SerializeField] private SceneName sceneName = SceneName.Scene1_Farm;
    [SerializeField] private Vector2Int finishPosition;
    [SerializeField] private AnimationClip idleDownAnimationClip = null;
    [SerializeField] private AnimationClip eventAnimationClip = null;
    private NPCMovement npcMovement;

    public GameObject Player;
    public float followDistance = 1f;
    private Vector3[] circleOffsets = new Vector3[] {
        new Vector3(1, 0, 0),
        new Vector3(-1, 0, 0),
        new Vector3(0, 1, 0),
        new Vector3(0, -1, 0)
    };
    private int circleIndex = 0;

    public float cooldownTime = 1f; // เวลาในการคูลดาวน์
    private bool isCooldown = false;

    static public SceneName PlayersceneName;

    public enum ModePet
    {
        Attack,
        Follow,
        Watch,
        Protect
    }

    public ModePet PetMode;

    private void Start()
    {
        npcMovement = npcPath.GetComponent<NPCMovement>();
        npcMovement.npcFacingDirectionAtDestination = Direction.down;
        npcMovement.npcTargetAnimationClip = idleDownAnimationClip;
    }

    private void Update()
    {
        if (PlayersceneName != sceneName)
        {
            sceneName = PlayersceneName;
        }

        float DistaceBetween = Vector2.Distance(npcPath.gameObject.transform.position, Player.transform.position);


        float distanceToPlayer = Vector2.Distance(npcPath.gameObject.transform.position, Player.transform.position);

        if (distanceToPlayer > followDistance)
        {
            follwerPlayer = true;
        }
        else
        {
            follwerPlayer = false;

            if (!isCooldown)
            {
                StartCoroutine(MoveAroundPlayerWithCooldown());
            }
        }

        if (moveNPC)
        {
            moveNPC = false;
            NPCScheduleEvent npcScheduleEvent = new NPCScheduleEvent(0, 0, 0, 0, Weather.none, Season.none, sceneName, new GridCoordinate(finishPosition.x, finishPosition.y), eventAnimationClip);
            npcPath.BuildPath(npcScheduleEvent);
        }

        if (follwerPlayer)
        {
            NPCScheduleEvent npcScheduleEvent = new NPCScheduleEvent(0, 0, 0, 0, Weather.none, Season.none, sceneName, new GridCoordinate((int)Player.transform.position.x, (int)Player.transform.position.y), null);
            npcPath.BuildPath(npcScheduleEvent);

        }
    }

    private IEnumerator MoveAroundPlayerWithCooldown()
    {
        isCooldown = true;

        // เริ่มการเคลื่อนที่ไปรอบๆผู้เล่น
        Vector3 targetPosition = Player.transform.position + circleOffsets[circleIndex];
        circleIndex = (circleIndex + 1) % circleOffsets.Length;

        NPCScheduleEvent npcScheduleEvent = new NPCScheduleEvent(0, 0, 0, 0, Weather.none, Season.none, sceneName, new GridCoordinate((int)targetPosition.x, (int)targetPosition.y), null);
        npcPath.BuildPath(npcScheduleEvent);

        // รอเวลาคูลดาวน์ก่อนจะเคลื่อนที่ครั้งต่อไป
        yield return new WaitForSeconds(cooldownTime);

        isCooldown = false;
    }
}
