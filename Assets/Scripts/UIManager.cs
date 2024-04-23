using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEditor;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;



public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI simText;

    //public Slider textSlider;

    [SerializeField]
    Button Options_Button;

    [SerializeField]
    GameObject Foward_Button;

    [SerializeField]
    GameObject Back_Button;

    [SerializeField]
    Button Menu_Button;

    [SerializeField]
    Button Play_Button;

    [SerializeField]
    Button Pause_Button;

    [SerializeField]
    Button Sound_Mute;

    [SerializeField]
    Button Sound_Button;

    [SerializeField]
    PlayableDirector Scene_Timeline;

    [SerializeField]
    GameObject Sound_Object;

    [SerializeField]
    GameObject Mute_Button;

    [SerializeField]
    Camera Camera;

    [SerializeField]
    GameObject Menu_Block;


    public bool M_Menu = false;
    public bool sound_Mute = false;

    //Back button 

    public GameObject[] Object_sequence;

    public double[] Timeline_Checkpoints;

    public int Object_num = 0;

    public int Skip_Button_Num = 0;

    public int OBJ_Max;
    public int OBJ_Min;

    public int TL_Max;
    public int TL_Min;


    private int Font_Counter = 0;

    void Start()
    {
        OBJ_Max = Object_sequence.Length - 1;
        OBJ_Min = 0;

        TL_Max = Timeline_Checkpoints.Length - 1;
        TL_Min = 0;

        Debug.Log("Number of checkpoints is " + TL_Max);

        Debug.Log("number of objects selected is " + OBJ_Max);

       

    }


    // Update is called once per frame
    void Update()
    {
        //timeline.time == episodestartime 
       // if current time == endtime { increment bject++ Tl++
    }


    public void Disable_Foward_Skip()
    {
        if (Skip_Button_Num == TL_Max)
        {
            Foward_Button.transform.GetComponent<Button>().interactable = false;  
            
            //Skip_Button_Num--;
        }
        else Foward_Button.transform.GetComponent<Button>().interactable = true;

        if (Skip_Button_Num != 0)
        {
            Back_Button.transform.GetComponent<Button>().interactable = true;

        }
        else Back_Button.transform.GetComponent<Button>().interactable = false;

        if (Skip_Button_Num == TL_Max)
        {
            Skip_Button_Num = TL_Max;

            //Object_num = OBJ_Max;
        }
    }

    public void Disable_Back_Skip()
    {
         if (Skip_Button_Num == 0 || Skip_Button_Num < 0)
         {
            Back_Button.transform.GetComponent<Button>().interactable = false;

            Object_num = OBJ_Min;

         }
         else Back_Button.transform.GetComponent<Button>().interactable = true;

       if (Skip_Button_Num != TL_Max)
       {
            Foward_Button.transform.GetComponent<Button>().interactable = true;
       }
       else Foward_Button.transform.GetComponent<Button>().interactable = false;


    }
    public void UpdateTextSize()
    {
        //simText.fontSize = textSlider.value;
    }

    public void Change_Font()
    {
        if (Font_Counter == 0)
        {
            simText.fontSize = 12;
        }
        else if (Font_Counter == 1)
        {
            simText.fontSize = 20;
        }
        else
        {
            simText.fontSize = 24;
        }


        Font_Counter++;

        if (Font_Counter == 3)
        {
            Font_Counter = 0;
        }
        
    }
    public void Pausing_Scene()
    {
        Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);
    }

    public void Play_Scene()
    {
        Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
    }

    public void Sound_Control()
    {
        sound_Mute = !sound_Mute;

        if (sound_Mute == true)
        {
            Sound_Object.SetActive(false);

            Mute_Button.SetActive(true);

            Camera.transform.GetComponent<AudioListener>().enabled = false;
        }
        else
        {
            Sound_Object.SetActive(true);

            Mute_Button.SetActive(false);

            Camera.transform.GetComponent<AudioListener>().enabled = true;
        }
    }

    public void MenuOptions()
    {
        M_Menu = !M_Menu;

        if (M_Menu == true)
        {
            Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);
            Menu_Block.SetActive(true);

        }
        else
        {

            Menu_Block.SetActive(false);

        }

    }

    public void Menu_NO()
    {
        Menu_Block.SetActive(false);
    }

    public void Drop_UI()
    {

    }



    public void Skip_Foward()
    {
       
        Debug.Log("Skip is active");

        if (Skip_Button_Num < TL_Max || Skip_Button_Num == -1)
        {
            Object_sequence[Object_num].transform.GetComponent<Outline>().enabled = false;

            Object_sequence[Object_num].transform.GetComponent<Collider>().enabled = false;

            //Back_Button.transform.GetComponent<Button>().interactable = true;

            Skip_Button_Num++;

            //Object_num++;

            Scene_Timeline.playableGraph.GetRootPlayable(0).SetTime(Timeline_Checkpoints[Skip_Button_Num]);
        }
        else
        {
            

        }


       

    }
    public void Skip_Back()
    {
        Debug.Log("Skip back is active");

            if (Skip_Button_Num >= TL_Min)
            {

                Object_sequence[Object_num].transform.GetComponent<Outline>().enabled = false;

                Object_sequence[Object_num].transform.GetComponent<Collider>().enabled = false;

                //Foward_Button.transform.GetComponent<Button>().interactable = true;

                Skip_Button_Num--;

                Object_num = Object_num - 2;

                Scene_Timeline.playableGraph.GetRootPlayable(0).SetTime(Timeline_Checkpoints[Skip_Button_Num]);
            }
            else
            {
                Skip_Button_Num = TL_Min;
               
                Object_num = OBJ_Min;

            }

            if (Object_num <= 0)
            {
                Object_num = OBJ_Min;
            }

    }
}
