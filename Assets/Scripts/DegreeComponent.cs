using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegreeComponent : MonoBehaviour
{
    [Range(1,4)]
    public float scalar = 0.0f;
    [Range(0,360)]
    public float degrees = 0.0f;
    public float dTime = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dTime += Time.deltaTime;
        float delta = scalar * Mathf.Sin(dTime);

        //πÊ«‚
        float x = delta * Mathf.Cos(Degree2Rad(degrees));
        float y = delta * Mathf.Sin(Degree2Rad(degrees));

        Vector3 dirVec = new Vector3(x, y, 0);
        transform.position = dirVec;

    }

    float Degree2Rad(float degrees)
    {
        return degrees * Mathf.PI / 180;
    }
}
