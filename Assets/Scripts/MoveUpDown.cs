using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    [Range(1, 4)]
    public float scalar = 0.0f;
    [Range(0, 360)]
    public float degrees = 0.0f;
    public float dTime = 0.0f;

    public Vector3 origin = new Vector3();

    void Start()
    {
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        dTime += Time.deltaTime;
        float delta = scalar * Mathf.Sin(dTime);

        //����
        float x = delta * Mathf.Cos(Degree2Rad(degrees));
        float y = delta * Mathf.Sin(Degree2Rad(degrees));

        Vector3 dirVec = new Vector3(x, y, 0);
        transform.position = origin + dirVec;

    }

    float Degree2Rad(float degrees)
    {
        return degrees * Mathf.PI / 180;
    }
}
