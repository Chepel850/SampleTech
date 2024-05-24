using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;
using TMPro;
using UnityEngine.UI;

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

    [SerializeField]
    AudioSource Source;

    [SerializeField]
    AudioSource Source_2;

    [SerializeField]
    AudioClip Wrong;

    [SerializeField]
    AudioClip Right;

    [SerializeField]
     Button CC_Button;

    

    // Start is called before the first frame update
    void Start()
    {
        UIManager = CC_Bool.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Setting_Check_Points();

        
    }


    public void Setting_Check_Points()
    {
        if (Scene_Timeline.time >= 80 && Scene_Timeline.time <= 90)
        {
            Selection_Count = 1;
        }
        else if (Scene_Timeline.time >= 90.5 && Scene_Timeline.time <= 94.5)
        {
            Selection_Count = 2;
        }
        else if (Scene_Timeline.time >= 95.4 && Scene_Timeline.time <= 101.5)
        {
            Selection_Count = 3;
        }
        else if (Scene_Timeline.time >= 102 && Scene_Timeline.time <= 106)
        {
            Selection_Count = 4;
        }
        else Selection_Count = 0;
    }
    public void Testing_active()
    {

        //UIManager.Close_Captioning = true;
         
        //Selection_Count++;

        Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);

        CC_Button.GetComponent<Button>().interactable = false;

        if (UIManager.Close_Captioning == false)
        {
            UIManager.Close_Captioning = false;
        }
        else if (UIManager.Close_Captioning == true)
        {
            UIManager.Close_Captioning = true;
            
            UIManager.Close_Captioning_Button();
        }
        
        

        Main_Button_Parent.SetActive(true);

    }
    public void  Small_Test_Solution()
    {
        


        if (Selection_Count == 1 && Ni == true && Sul == false && Fri == false && no == false)
            {
                Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
                Reset_Test();
                Ni = false;
                Main_Button_Parent.SetActive(false);
                Source_2.Play();
                All_Clear();

                //UIManager.Close_Captioning = true;
            }
        else if (Selection_Count == 2 && Fri == true && Ni == false && Sul == false && no == false)
             {
                Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
                Reset_Test();
                Fri = false;
                Main_Button_Parent.SetActive(false);
                Source_2.Play();
                All_Clear();

                //UIManager.Close_Captioning = true;
             }
        else if (Selection_Count == 3 && Sul == true && Fri == true && Ni == false && no == false)
             {
                Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
                Source_2.Play();
                Reset_Test();

                All_Clear();

                Sul = false;

                Fri = false;

                Main_Button_Parent.SetActive(false);

                //UIManager.Close_Captioning = true;
             }
        else if (Selection_Count == 4 &&  no == true && Sul == false && Fri == false && Ni == false)
             {
                Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);

                Reset_Test();

                Source_2.Play();

                no = false;

                Main_Button_Parent.SetActive(false);

                All_Clear();

                //UIManager.Close_Captioning = true;
             }
            else
            {
                Playing_Wrong_Sound();
                Debug.Log("Selection Count or Ni is false or not the correct number");
            }

    }

    public void Playing_Wrong_Sound()
    {
        Source.time = (float)1.8;
        Source.Play();
    }

    public void PLaying_Right_Sound()
    {

        Source_2.Play();
       
    }

    public void Fridge_ButtonClick()
    {
        Fri = !Fri;

        if(Fri == true)
        {
            Fridge.transform.GetComponent<Image>().color = Color.gray;
        }
        else { Fridge.transform.GetComponent<Image>().color = Color.white; }
    }
    public void Nitric_ButtonClick()
    {
        Ni = !Ni;
        if (Ni == true)
        {
            Nitric.transform.GetComponent<Image>().color = Color.gray;
        }
        else { Nitric.transform.GetComponent<Image>().color = Color.white; }
    }
    public void Sulfiric_ButtonClick()
    {
        Sul = !Sul;

        if (Sul == true)
        {
            Sulfiric.transform.GetComponent<Image>().color = Color.gray;
        }
        else { Sulfiric.transform.GetComponent<Image>().color = Color.white; }
    }
    public void None_ButtonClick()
    {
        no = !no;

        if (no == true)
        {
            None_Button.transform.GetComponent <Image>().color = Color.gray;
        }
        else { None_Button.transform.GetComponent<Image>().color = Color.white; }
    }

    public void All_Clear()
    {
        Fridge.transform.GetComponent<Image>().color = Color.white;

        Nitric.transform.GetComponent<Image>().color = Color.white;

        Sulfiric.transform.GetComponent<Image>().color = Color.white;

        None_Button.transform.GetComponent<Image>().color = Color.white;
    }

    public void EnableCC()
    {
        CC_Button.GetComponent<Button>().interactable = true ;
    }

    public void Reset_Test()
    {
        Fri = false;
        Sul = false;
        Ni = false;
        no = false;
    }


}
