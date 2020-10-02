using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5_Camera : MonoBehaviour
{
    public GameObject target;
    public float sentivity = 1000;
    public float distance;
    public Vector3 offset;
    [Range(5,89)]
    public float limitAngleMin = 80.0f;
    [Range(5, 89)]
    public float limitAngleMax = 80.0f;


    [HideInInspector]
    public GameObject axis1;
    [HideInInspector]
    public GameObject axis2;

    private Vector3 currentEular;

    void Start()
    {
        axis1 = new GameObject("Cam_axis1");
        axis2 = new GameObject("cam_axis2");

        axis2.transform.parent = axis1.transform;
        this.transform.parent = axis2.transform;

        this.transform.localPosition = Vector3.zero;
        axis1.transform.rotation = target.transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        target.transform.eulerAngles = new Vector3(0, axis1.transform.eulerAngles.y, 0);
        axis1.transform.position = target.transform.position + offset;
        axis2.transform.localPosition = -Vector3.forward * distance;

        currentEular += Vector3.right * (-sentivity * Input.GetAxis("Mouse Y")) * Time.deltaTime;
        currentEular += Vector3.up * (sentivity * Input.GetAxis("Mouse X")) * Time.deltaTime;

        currentEular.x = Mathf.Clamp(currentEular.x, -limitAngleMax, -limitAngleMin);

        axis1.transform.localRotation = Quaternion.Euler(currentEular);
    }
}
