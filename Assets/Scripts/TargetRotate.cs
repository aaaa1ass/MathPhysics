using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotate : MonoBehaviour
{
    public Transform Target;
    public Transform Root;
    public GameObject Shot;

    private float degree;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Target != null)
        {
            float x = Target.position.x - Root.position.x;
            float y = Target.position.y - Root.position.y;
            float tan = y / x;

            float radianTan = Mathf.Atan(tan);
            degree = Rad2Degrees(radianTan);

            Root.localRotation = Quaternion.Euler(0, 0, degree);
        }    
    }

    float Rad2Degrees(float rad)
    {
        return rad * 180 / Mathf.PI;
    }
}
