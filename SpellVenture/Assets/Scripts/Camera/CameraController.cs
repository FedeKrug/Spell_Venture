using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector3 cameraPos;
    [SerializeField, Range(-20, 20)] float xOffset, yOffset;
    // Start is called before the first frame update
    void Awake()
    {
        cameraPos = this.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = new Vector3(target.transform.position.x +xOffset, target.transform.position.y + yOffset, cameraPos.z);
        //TODO: Optimize the camera controller and take reference from Stray Journey
    }
    
}
