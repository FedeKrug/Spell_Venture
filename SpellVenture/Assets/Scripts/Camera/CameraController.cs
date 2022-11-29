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
    void Update()
    {
        this.transform.position = new Vector3(target.transform.position.x +xOffset, target.transform.position.y + yOffset, cameraPos.z);
    }
    
}
