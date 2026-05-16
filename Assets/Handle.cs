using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Handle : MonoBehaviour
{
    private List<Joycon> joycons;
    private Joycon joycon;

    public float sensitivity = 2.0f;   // 感度
    public float smooth = 5.0f;        // なめらかさ

    private Vector3 currentRotation;

    void Start()
    {
        joycons = JoyconManager.Instance.j;


        if (joycons.Count > 0)
        {
            joycon = joycons[0];
        }
    }

    void Update()
    {
        if (joycon == null) return;

        Vector3 gyro = joycon.GetGyro();
        Vector3 rotation = new Vector3(0,gyro.z,0) * sensitivity;
        transform.localRotation = Quaternion.Euler(0, transform.localEulerAngles.y, 0);
        //なめらかに動かす
        currentRotation = Vector3.Lerp(currentRotation, rotation, Time.deltaTime * smooth);

        transform.Rotate(currentRotation * Time.deltaTime);


    }
}