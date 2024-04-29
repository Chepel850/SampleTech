using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class Sampling_Testing : MonoBehaviour
{
    [SerializeField]
    GameObject Main_Button_Parent;

    [SerializeField]
    GameObject Fridge;

    [SerializeField]
    GameObject None_Button;

    [SerializeField]
    GameObject Nitric;

    [SerializeField]
    GameObject Sulfiric;

    public bool Fri;
    public bool no;
    public bool Ni;
    public bool Sul;

    public int Selection_Count;

    [SerializeField]
    PlayableDirector Scene_Timeline;

    [SerializeField]
    GameObject CC_Bool;

    UIManager UIManager;

    // Start is called before the first frame update
    void Start()
    {
        UIManager = CC_Bool.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Testing_active()
    {

        UIManager.Close_Captioning = true;
         
        Selection_Count++;
        Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);
        Main_Button_Parent.SetActive(true);

    }
    public void  Small_Test_Solution()
    {
        if (Selection_Count == 1 && Ni == true)
        {
            Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
            Main_Button_Parent.SetActive(false);
            UIManager.Close_Captioning = true;
        }
        else Debug.Log("Selection Count or Ni is false or not the correct number");
        
        if(Selection_Count == 2 && Fri == true)
        {
            Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
            Main_Button_Parent.SetActive(false);
            UIManager.Close_Captioning = true;
        }
        else Debug.Log("Selection Count or Ni is false or not the correct number");

        if (Selection_Count == 3 && Sul == true && Fri == true)
        {
            Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
            Main_Button_Parent.SetActive(false);
            UIManager.Close_Captioning = true;
        }
        else Debug.Log("Selection Count or Ni is false or not the correct number");

        if (Selection_Count == 4 &&  no == true)
        {
            Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
            Main_Button_Parent.SetActive(false);
            UIManager.Close_Captioning = true;
        }
        else Debug.Log("Selection Count or Ni is false or not the correct number");
    }


    public void Fridge_ButtonClick()
    {
        Fri = !Fri;
    }
    public void Nitric_ButtonClick()
    {
        Ni = !Ni;
    }
    public void Sulfiric_ButtonClick()
    {
        Sul = !Sul;
    }
    public void None_ButtonClick()
    {
        no = !no;
    }
}
