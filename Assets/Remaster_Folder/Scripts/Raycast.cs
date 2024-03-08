using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class Raycast : MonoBehaviour
{

    [SerializeField]
    Camera cam;

    [SerializeField]
    PlayableDirector Sample_Tech_Timeline;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;

        //Sample_Tech_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);
    }

    // Update is called once per frame
    void Update()
    {
        Raycast_Initiation();
    }

    public void Raycast_Initiation()
    {
        RaycastHit hit;

        Ray lightray = Camera.main.ScreenPointToRay(Input.mousePosition);


        if (Input.GetMouseButtonDown(0))
        {
           if (Physics.Raycast(lightray, out hit))
            {
                Debug.Log("Object has been hit");

                hit.transform.GetComponent<Outline>().enabled = false;

                hit.transform.GetComponent<Collider>().enabled = false;

                Sample_Tech_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
                
            }
            
        }


    }

    public void TL_Stop()
    {
        Sample_Tech_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);
    }
}

