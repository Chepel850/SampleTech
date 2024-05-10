using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Aseptic_Sequence : MonoBehaviour
{
    [SerializeField]
    GameObject Spray_Bottle;

    [SerializeField]
    GameObject Airator;

    [SerializeField]
    GameObject Bottle;

    [SerializeField]
    GameObject Packet;

    [SerializeField]
    GameObject Cold_Faucet_Handle;

    [SerializeField]
    GameObject Bottle_Lid;

    [SerializeField]
    GameObject Just_Bottle;


    public void Spray_Bottle_Highlight()
    {
        Spray_Bottle.transform.GetComponent<Outline>().enabled = true;
        Spray_Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    public void Airator_Highlight()
    {
        Airator.transform.GetComponent<Outline>().enabled = true;
        Airator.transform.GetComponent <Collider>().enabled = true;

    }

    public void Bottle_Highlight()
    {
        Bottle.transform.GetComponent<Outline>().enabled = true;
        Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    public void Packet_Highlight()
    {
        Packet.transform.GetComponent<Outline>().enabled = true;
        Packet.transform.GetComponent<Collider>().enabled=true;
    }

    public void Cold_Faucet_Highlight()
    {
        Cold_Faucet_Handle.transform.GetComponent<Outline>().enabled = true;
        Cold_Faucet_Handle.transform.GetComponent<Collider>().enabled = true;
    }

    public void Lid_Highlight()
    {
        Bottle_Lid.GetComponent<Outline>().enabled = true;
        Bottle_Lid.GetComponent <Collider>().enabled = true;
    }

    public void Just_Bottle_Highlight()
    {
        Just_Bottle.GetComponent<Outline>().enabled = true;
        Just_Bottle.GetComponent <Collider>().enabled = true;
    }
}
