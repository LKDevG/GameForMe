using UnityEngine;

public class PetController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform player;
    public float followDistance = 1f;
    public float wanderRadius = 2f;
    public float waitTime = 1f;

    private Animator animator;
    private Vector3 targetPosition;
    private Vector3 wanderPoint;
    private bool isFollowing = false;
    private bool isWaiting = false;
    private float waitTimer = 0f;

    void Start()
    {
        animator = GetComponent<Animator>();
        ChooseWanderPoint();
    }

    void Update()
    {
        if (IsNearPlayer())
        {
            if (!isFollowing)
            {
                ChooseWanderPoint();
                isFollowing = true;
            }
            WanderAround();
        }
        else
        {
            FollowPlayer();
        }
        AnimatePet();
    }

    bool IsNearPlayer()
    {
        return Vector3.Distance(transform.position, player.position) <= followDistance;
    }

    void FollowPlayer()
    {
        isFollowing = false;
        targetPosition = player.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    void WanderAround()
    {
        if (isWaiting)
        {
            waitTimer -= Time.deltaTime;
            if (waitTimer <= 0)
            {
                isWaiting = false;
                animator.SetBool("isWalking", true);
                ChooseWanderPoint();
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, wanderPoint, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, wanderPoint) < 0.1f)
            {
                isWaiting = true;
                animator.SetBool("isWalking", false);
                waitTimer = waitTime;
            }
        }
    }

    void ChooseWanderPoint()
    {
        wanderPoint = player.position + Random.insideUnitSphere * wanderRadius;
        wanderPoint.z = player.position.z;
    }

    void AnimatePet()
    {
        Vector3 direction = targetPosition - transform.position;
        if (direction.magnitude > 0.1f || isWaiting)
        {
            animator.SetBool("isWalking", true);

            // กำหนดการเคลื่อนไหวตามทิศทาง
            animator.SetFloat("MoveX", direction.x);
            animator.SetFloat("MoveY", direction.y);

            // กำหนดการหันตามทิศทางการเคลื่อนไหว
            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                if (direction.x > 0)
                {
                    // หันขวา
                    animator.SetFloat("LastMoveX", 1);
                    animator.SetFloat("LastMoveY", 0);
                }
                else
                {
                    // หันซ้าย
                    animator.SetFloat("LastMoveX", -1);
                    animator.SetFloat("LastMoveY", 0);
                }
            }
            else
            {
                if (direction.y > 0)
                {
                    // หันขึ้น
                    animator.SetFloat("LastMoveX", 0);
                    animator.SetFloat("LastMoveY", 1);
                }
                else
                {
                    // หันลง
                    animator.SetFloat("LastMoveX", 0);
                    animator.SetFloat("LastMoveY", -1);
                }
            }
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
