using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab_Sampling_Procedure : MonoBehaviour
{
    [SerializeField]
    GameObject Sample_Bottle_1;

    [SerializeField]
    GameObject Sample_Bottle_2;

    [SerializeField]
    GameObject Sample_Bottle_3;

    [SerializeField]
    GameObject Cooler;

    [SerializeField]
    GameObject Perserve_Bottle;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void First_Bottle_Highlight()
    {
        Sample_Bottle_1.transform.GetComponent<Outline>().enabled = true;
        Sample_Bottle_1.transform.GetComponent<Collider>().enabled = true;
    }

    public void Second_Bottle_Highlight()
    {
        Sample_Bottle_2.transform.GetComponent<Outline>().enabled = true;
        Sample_Bottle_2.transform.GetComponent<Collider>().enabled = true;
    }

    public void Thrid_Bottle_Highlight()
    {
        Sample_Bottle_3.transform.GetComponent<Outline>().enabled = true;
        Sample_Bottle_3.transform.GetComponent<Collider>().enabled = true;
    }

    public void Cooler_Highlight()
    {
        Cooler.transform.GetComponent<Outline>().enabled = true;
        Cooler.transform.GetComponent<Collider>().enabled = true;
    }
}
