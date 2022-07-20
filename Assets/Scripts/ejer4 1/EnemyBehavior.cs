using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Transform player;
    
    public float moveSpeed = 2f;

    public float chrono;
    public int rutine;

    public Animator anim;

    public float simpleAttackRange = 9f;

    void Awake () {
        
    }
    private void Start() {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void Update() {
        followPlayer();
        simpleAttack();     

        chrono += 1 * Time.deltaTime;
        if (chrono >= Random.Range(1,4))
        {
            rutine = Random.Range(0, 3);
            chrono = 0;
        }

        if(rutine <= 1){
            anim.SetBool("isWalking", false);
            moveSpeed *= 0;
        }
        if(rutine > 1){
            anim.SetBool("isWalking", true);
            moveSpeed = 2;
        }
        
    }

    private void simpleAttack(){
        if( (transform.position - player.transform.position).sqrMagnitude < simpleAttackRange )
        {
            anim.SetBool("isAttacking", true);
        } else {
            anim.SetBool("isAttacking", false);
        }
    }

    private void followPlayer(){
        if (transform.position.x < player.transform.position.x)
        {            
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

}
