using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
    public Transform HandleObject;
    public float spead = 7f;
    public float sensitivity = 0f;
    public float maxspead = 10f;
    public float rotationsensitivity = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        float Rotatey = HandleObject.localEulerAngles.y;
        float Rotatez = HandleObject.localEulerAngles.y + 90;
        Vector3 bikeRotate = transform.eulerAngles;
        Vector3 Angle = transform.eulerAngles;
        if (Rotatey > 180f)
        {
            Rotatey -= 270f;
        }     
        transform.position += transform.forward * spead * Time.deltaTime;
        transform.Rotate(0, Rotatey * sensitivity * Time.deltaTime, 0);
        transform.localRotation = Quaternion.Euler(Angle.x, transform.localEulerAngles.y, -Rotatez);        
        //transform.localEulerAngles = -Vector3.forward * y * sensitivity * Time.deltaTime *2;
        if (spead <= maxspead)
        {
            spead += 1 / (spead * 5);
        }
        if(Angle.x <= -2.9)
        {
            Debug.Log("ŒXŽÎ ‘å");
        }
        else if(Angle.x <= -4.7)
        {
            Debug.Log("ŒXŽÎ ’†");
        }
        else if(Angle.x <= -7)
        {
            Debug.Log("ŒXŽÎ ¬");
        }        
        //Debug.Log(y);
    }
}
