using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowComponent : MonoBehaviour
{
    public Transform targetObject;
    public Vector3 dirVec;
    public float movSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if(targetObject != null)
        {
            float x = targetObject.position.x - transform.position.x;
            float y = targetObject.position.y - transform.position.y;

            double total = System.Math.Pow(x, 2) + System.Math.Pow(y, 2);

            double range = System.Math.Sqrt(total);

            if(range > 0.1f && range < 3.0f)
            {
                dirVec = new Vector3(x, y, 0);

                transform.position += dirVec.normalized * movSpeed * Time.deltaTime;
            }


        }

    }
}
