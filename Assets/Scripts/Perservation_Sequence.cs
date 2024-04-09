using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perservation_Sequence : MonoBehaviour
{
    [SerializeField]
    GameObject Copper_Bottle;

    [SerializeField]
    GameObject BOD_Bottle;

    [SerializeField]
    GameObject NA;

    [SerializeField]
    GameObject pH;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Copper_Bottle_Highlight()
    {
        Copper_Bottle.transform.GetComponent<Outline>().enabled = true;
        Copper_Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    public void BOD_Bottle_Highlight()
    {
        BOD_Bottle.transform.GetComponent<Outline>().enabled = true;
        BOD_Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    public void NA_BOttle_Highlight()
    {
        NA.transform.GetComponent<Outline>().enabled = true;
        NA.transform.GetComponent<Collider>().enabled = true;
    }

    public void pH_Bottle_Highlight()
    {
        pH.transform.GetComponent<Outline>().enabled = true;
        pH.transform.GetComponent<Collider>().enabled = true;
    }
}
