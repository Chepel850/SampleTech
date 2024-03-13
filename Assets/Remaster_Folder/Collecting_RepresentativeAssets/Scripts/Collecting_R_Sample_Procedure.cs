using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collecting_R_Sample_Procedure : MonoBehaviour
{

    [SerializeField]
    GameObject First_Bottle;

    [SerializeField]
    GameObject First_Main_Bottle;

    [SerializeField]
    GameObject Second_Bottle;

    [SerializeField]
    GameObject Second_Main_Bottle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CRS_Outline_First_Bottle()
    {
        First_Bottle.transform.GetComponent<Outline>().enabled = true;
        First_Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    public void CRS_Outline_Second_Bottle()
    {
        Second_Bottle.transform.GetComponent<Outline>().enabled = true;
        Second_Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    public void CRS_Main_First_Bottle_Highlight()
    {
        First_Main_Bottle.transform.GetComponent<Outline>().enabled = true;
        First_Main_Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    public void CRS_Main_Second_Bottle_Highlight()
    {
        Second_Main_Bottle.transform.GetComponent<Outline>().enabled = true;
        Second_Main_Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    
}
