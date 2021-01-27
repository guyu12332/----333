using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent nav;
    public Animator ani;
    public int hp;
    public GameObject target;
    public Vector3 pos;
    public AnimatorStateInfo state;
    private void Awake()
    {
        hp = 1000;
        nav = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();
        nav.speed = 1;
    }
 
    void Start()
    {
        pos = new Vector3(Random.Range(-30, 30), 0, Random.Range(-30, 30));
    }
   
    void Update()
    {
        state = ani.GetCurrentAnimatorStateInfo(0);

        ani.SetBool("Run", true);
        if (GameObject.Find("Player") != null)
        {
            target = GameObject.Find("Player");
        }
        if (target != null)
        {
            if (Vector3.Distance(transform.position, target.transform.position) < 10)
            {
                nav.SetDestination(target.transform.position);
                if (Vector3.Distance(transform.position, target.transform.position) < 3)
                {
                    ani.SetTrigger("Attack");
                }
            }
            else
            {
                nav.SetDestination(pos);
                if (Vector3.Distance(transform.position, pos) < 1)
                {
                    pos = new Vector3(Random.Range(-30, 30), 0, Random.Range(-30, 30));
                }
            }
        }
        else
        {
            nav.SetDestination(pos);
            if (Vector3.Distance(transform.position, pos) < 1)
            {
                pos = new Vector3(Random.Range(-30, 30), 0, Random.Range(-30, 30));
            }
        }
    }
    public void SetIdle()
    {
        ani.SetBool("Run", false);
    }
    //怪物受到攻击判断
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            if (hp > 20)
            {
                hp -= 20;
            }
            else
            {
                Destroy(gameObject, 2);
            }

            Destroy(other.gameObject);
        }
    }
}
