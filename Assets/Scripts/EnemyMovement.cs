using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject PurpleSphere, GreenSphere, OrangeSphere;
    Vector3 _deltaPos = new Vector3(1,0);
    Vector3 _startingPosition = new Vector3(-12f, 0);
    float _nextTime;
    const float MIN_TIME = 0.2f, MAX_TIME = 1.5f, MIN_Y = -4, MAX_Y = 4;

    // Start is called before the first frame update
    void Start()
    {
        _nextTime = Time.time + Random.Range(MIN_TIME, MAX_TIME);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > _nextTime){
            _startingPosition.y = Random.Range(MIN_Y, MAX_Y);
            Instantiate(NextSphere(), _startingPosition, Quaternion.identity);
            _nextTime = GetNextTime();
        }
        
    }

    float GetNextTime(){
        return Time.time + Random.Range(MIN_TIME, MAX_TIME);
    }

    GameObject NextSphere(){
        switch (Random.Range(0,3))
        {
            case 0:
                return PurpleSphere;
            case 1:
                return OrangeSphere;
            default:
                return GreenSphere;
        }
    }
}
