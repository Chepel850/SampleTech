using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Raycast : MonoBehaviour
{

    [SerializeField]
    Camera cam;

    [SerializeField]
    PlayableDirector Sample_Tech_Timeline;

    [SerializeField]
    GameObject Tl_Counter;

    UIManager tl_skip_num;


    // Start is called before the first frame update
    void Start()
    {
        tl_skip_num = Tl_Counter.GetComponent<UIManager>();

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

                //tl_skip_num.Skip_Button_Num =;

                //tl_skip_num.Object_num = tl_skip_num.Scene_Timeline
                
            }
            
        }


    }

    public void TL_Stop()
    {
        Sample_Tech_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);

        tl_skip_num.Object_num++;

        tl_skip_num.Skip_Button_Num  = tl_skip_num.Object_num;


    }

    public void Timeline_Pause()
    {
        Sample_Tech_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);
    }

    public void End_Of_Scene()
    {

        SceneManager.LoadScene("MainMenu");

    }
}

