using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public bool handR = false;
    public bool handL = false;
    public bool handS = false;
    public bool Left = false;
    public float errur = 1;
    Vector3 Handposion;
    public float ShoulderWidth;
    // Start is called before the first frame update
    void Start()
    {
        if(Left==true)
        {
            ShoulderWidth = -ShoulderWidth;
        }
    }
    public void Tpose()
    {
        Handposion = transform.position;
    }
    // Update is called once per frame
    void Update()
    {   

        //˜r‚Ì”ä—¦ Œ¨‚©‚ç•I:•I‚©‚çèñ:èñ‚©‚çwæ=1:1:2/3
        Vector3 Nowhand = transform.position;
        if ((handL == true && handR == true) || (handS == true && handL == true) || (handS == true && handR == true))
        {
            Debug.Log("ƒTƒCƒ“•¡”");
            handS = false;
            handR = false;
            handL = false;
        }
        if (Mathf.Abs(Nowhand.x - Handposion.x) <= errur &&
            Mathf.Abs(Nowhand.y - Handposion.y) <= errur &&
            Mathf.Abs(Nowhand.z - Handposion.z) <= errur)
        {
            if (Left == true)
            {
                handL = true;
                Debug.Log("Right");
            }
            else
            {
                handR = true;
                Debug.Log("Right");
            }
        }
        else
        {
            handR = false;
        }
        if (Mathf.Abs(Nowhand.x - Handposion.x) <= errur &&
            Mathf.Abs(Nowhand.y - Handposion.y) <= errur &&
            Mathf.Abs(Nowhand.z - Handposion.z) <= errur)
        {
            handL = true;
            Debug.Log("Left");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Stop")
        {
            Debug.Log("Stop");
            handS = true;
        }
        else
        {
            handS = false;
        }
        if (other.gameObject.tag == "Right")
        {
            Debug.Log("Right");
            handR = true;
        }
        else
        {
            handR = false;
        }
        if (other.gameObject.tag == "Left")
        {
            Debug.Log("Left");
            handL = true;
        }
        else
        {
            handL = false;
        }
    }
}
