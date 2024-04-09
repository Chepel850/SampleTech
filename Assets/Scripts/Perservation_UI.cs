using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class Perservation_UI : MonoBehaviour
{
    [SerializeField]
    Button Fridge;

    [SerializeField]
    Button HNO3;

    [SerializeField]
    Button H2SO4;

    [SerializeField]
    Button None;

    [SerializeField]
    Button Revise;

    [SerializeField]
    PlayableDirector Perservation_Timeline;

    private bool Fridge_Check = false;
    public bool HNO3_Check = false;
    private bool H2SO4_Check = false;
    private bool None_Check = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void copper_True()
    {
        HNO3_Check = true;
        Debug.Log("The button for copper has been pressed");

    }
    public void BOD_True()
    {
        Fridge_Check = true;
    }
    public void NA_True()
    {
        Fridge_Check = true;
        H2SO4_Check = true;
    }
    public void pH_True()
    {
        None_Check = true;
    }

    public void Check_Button()
    {
      if (HNO3_Check == true)
      {
            Perservation_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
            //HNO3_Check = false;
      }
        else
        {
            Debug.Log("The Check system did not work");
        }
    }
}
