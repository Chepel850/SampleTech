using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab_and_Composite_Samples_Procedure : MonoBehaviour
{
    [SerializeField]
    GameObject Small_Bottle;

    [SerializeField]
    GameObject Big_Container;

    [SerializeField]
    GameObject Other_Bottle1;

    [SerializeField]
    GameObject Other_Bottle2;

    [SerializeField]
    GameObject Cooler;

    [SerializeField]
    GameObject Other_Bottle3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Small_Bottle_Highlight()
    {
        Small_Bottle.transform.GetComponent<Outline>().enabled = true;
        Small_Bottle.transform.GetComponent<Collider>().enabled = true;

    }

    public void Big_Container_highlight()
    {
        Big_Container.transform.GetComponent<Outline>().enabled = true;
        Big_Container.transform.GetComponent<Collider>().enabled = true;
    }

    public void Cooler_Highlight()
    {
        Cooler.transform.GetComponent<Outline>().enabled = true;
        Cooler.transform.GetComponent<Collider>().enabled = true;
    }

    public void Other_Container_Highlights()
    {
        Other_Bottle1.transform.GetComponent<Outline>().enabled = true;
        //Other_Bottle1.transform.GetComponent<Collider>().enabled = true;

        Other_Bottle2.transform.GetComponent<Outline>().enabled = true;
        //Other_Bottle2.transform.GetComponent<Collider>().enabled = true;

        Other_Bottle3.transform.GetComponent<Outline>().enabled = true;
    }

    public void Other_Container_Highlights_OFF()
    {
        Other_Bottle1.transform.GetComponent<Outline>().enabled = false;
        //Other_Bottle1.transform.GetComponent<Collider>().enabled = false;

        Other_Bottle2.transform.GetComponent<Outline>().enabled = false;
        //Other_Bottle2.transform.GetComponent<Collider>().enabled = false;

        Other_Bottle3.transform.GetComponent<Outline>().enabled = false;
    }


}
