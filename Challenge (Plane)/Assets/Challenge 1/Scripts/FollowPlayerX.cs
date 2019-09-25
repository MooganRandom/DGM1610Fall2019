using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);
    private float Vector3 = new Vector3(0f, 90f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        FollowPlayerX.transform.position = new Vector3(0f, 90f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Offset Camera on right side of plane following
        transform.position = plane.transform.position + offset;

        // Float rotate camera right of plane
        transform.Rotate = (0, 90, 0);
    }
}
