using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    public Transform target;

    public float speed = 0.5f;
    public float distance = 3f;
    Rigidbody2D rigidBody2D;
    Physics2D physics2D;
    Animator animator;
    public int hp;

    public GameObject DiePre;
    private string rotaBack;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.position);
        if (target.position.x < transform.position.x)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
            rotaBack = "left";
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
            rotaBack = "right";
        }
        transform.Rotate(new Vector3(0.0f, 0.0f, 0.0f), Space.Self);
        animator.SetBool("isWalk", false);
        if (Vector3.Distance(transform.position, target.position) < distance)
        {
            animator.SetBool("isWalk", true);
            transform.Translate(new Vector3(speed * Time.deltaTime, 0.0f, 0.0f));
        }
        if (hp <= 0)
        {
            Destroy(this.gameObject);
            Instantiate(DiePre, transform.position, transform.rotation);
            //SimpleCameraShakeInCinemachine.Shake = SimpleCameraShakeInCinemachine.Shake + 1;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Melee")
        {
            Destroy(other.gameObject);
            CheckrotaBack();
            hp = hp - 2;
        }
        if (other.gameObject.tag == "Knife")
        {
            Destroy(other.gameObject);
            CheckrotaBack();
            hp = hp - 5;
        }
        if (other.gameObject.tag == "Gun")
        {
            Destroy(other.gameObject);
            CheckrotaBack();
            hp = hp - 10;
        }
    }

    public void CheckrotaBack()
    {
        if (rotaBack == "left")
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * 60);
        }
        if (rotaBack == "right")
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * 60);
        }
    }
}
