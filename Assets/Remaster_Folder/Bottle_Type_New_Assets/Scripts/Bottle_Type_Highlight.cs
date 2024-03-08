using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bottle_Type_Highlight : MonoBehaviour
{

    [SerializeField]
    GameObject Plastic_Bottle;

    [SerializeField]
    GameObject Amber_Bottle;

    [SerializeField]
    GameObject Glass_Bottle;

    //Thermo_Coll.GetComponent<Outline>().enabled = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Glass_Bottle_Highlight_Function()
    {
        Glass_Bottle.transform.GetComponent<Outline>().enabled = true;
        Glass_Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    public void Amber_Bottle_Highlight_Function()
    {
        Amber_Bottle.transform.GetComponent<Outline>().enabled = true;
        Amber_Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    public void Plastic_Bottle_Highlight_Function()
    {
        Plastic_Bottle.transform.GetComponent<Outline>().enabled = true;
        Plastic_Bottle.transform.GetComponent<Collider>().enabled = true;
    }

    public void End_Of_Bottle_Type()
    {
        SceneManager.LoadScene("MainMenu3");
    }
}
