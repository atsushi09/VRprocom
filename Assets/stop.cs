using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    public bool stoped = false;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Take1()
    {
        stoped = true;
    }
    void Take2()
    {
        player.fine+=5000;//ˆêŽž’âŽ~”±‹à’Ç‰Á
    }
    private void Take3()
    {
        stoped = false;
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (stoped == false)
            {
                Invoke("Take1", 3.0f);
            }
            else
            {

            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag =="Playre")
        {
            if (stoped==false)
            {
                Invoke("Take2", 0.5f);
            }
            else
            {
                Invoke("Take3", 0.5f);
            }
        }
    }
}