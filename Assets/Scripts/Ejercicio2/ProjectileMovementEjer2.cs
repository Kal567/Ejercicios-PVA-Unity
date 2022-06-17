using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovementEjer2 : MonoBehaviour
{
    float lastTime, deltaTime, initialSpeed = 12f;

    Vector2 proyectilePos = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime = Time.time - lastTime;
        proyectilePos.y = initialSpeed * deltaTime + Physics.gravity.y * Mathf.Pow(deltaTime, 2)/2;
        initialSpeed += Physics.gravity.y * deltaTime;
        lastTime = Time.time;
        gameObject.transform.Translate(proyectilePos);
    }

    private void OnCollisionEnter(Collision other) {
        if(initialSpeed < 0){
            ScoreManager.currentScore++;
            print("score = " + ScoreManager.currentScore);
        }
        Destroy(gameObject);
    }

    
}
