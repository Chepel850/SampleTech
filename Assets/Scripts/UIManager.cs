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
using DG.Tweening;
using System;
using UnityEngine.Rendering;



public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI simText;

    public TextMeshProUGUI Big_text_Sim;

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

    //Back button -------------------------------------------------------------

    public GameObject[] Object_sequence;

    public double[] Timeline_Checkpoints;

    public int Object_num = 0;
    public int Skip_Button_Num = 0;

    public int OBJ_Max;
    public int OBJ_Min;

    public int TL_Max;
    public int TL_Min;
    //-------------------------------------------------

    //-------------------------------------------------
    private int Font_Counter = 0;
    //-----------------------------------------------------------------------------

    [SerializeField] RectTransform Text_Frame, Small_Box_Tool, TB_Position, Text_Box, Big_text_Box;

    [SerializeField] GameObject Small_text;
    [SerializeField] GameObject Big_Text;

    private float anim_Length = 1;

    public bool Close_Captioning = false;

    public Vector2 Original_Small_Tool_UI;
    public Vector2 Tool_UI_Top_location;

    public Vector2 Text_Frame_location;
    public Vector2 Text_Frame_top_location;
    public Vector2 Big_Text_Top_Location;

    public Vector2 Tool_UI_MAX;
    public Vector2 Tool_UI_Min;

    public Vector2 Tool_UI_OG_MAX;
    public Vector2 Tool_UI_OG_MIN;

    public Vector2 Big_text_OG;

    /*public Vector2 Text_Box_Original_location;
    public Vector2 Text_Box_Top_location;*/
    //-------------------------------------------
    [SerializeField]
    GameObject Foward_Dummy;
    [SerializeField]
    GameObject Back_Skip_Dummy;
    //------------------------------------------
    public string EARTH_WEB;
    //-----------------------------------------

    
    public string Coll_Sub;

    public string UN_Coll_Sub;

    [SerializeField]
    [TextArea]
    public List<string> Large_Dialog_Box;

    [SerializeField]
    [TextArea]
    public List<string> Small_Dialog_Box;

    public int Text_Counter = 0;
    public int Small_Text_Count = 0;

    //-----
    [SerializeField]
    GameObject End_Block;
     
    void Start()
    {
        Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);

        OBJ_Max = Object_sequence.Length - 1;
        OBJ_Min = 0;
        //----------------------------------------------
        TL_Max = Timeline_Checkpoints.Length - 1;
        TL_Min = 0;
        //----------------------------------------------
        Debug.Log("Number of checkpoints is " + TL_Max);

        Debug.Log("number of objects selected is " + OBJ_Max);

        //-------------------------------------------------------------------
        Original_Small_Tool_UI = Small_Box_Tool.transform.localPosition;

        Tool_UI_Top_location = TB_Position.transform.localPosition;
        //-----------------------------------------------------------------------------
        Text_Frame_location = new Vector2(1,(float) 0.125127316);

        Text_Frame_top_location = new Vector2(1, (float)0.2318369);

        Big_Text_Top_Location = new Vector2 (1, (float)0.221812963);

        Big_text_OG = new Vector2(1,(float)0.01720461);

        Tool_UI_MAX = new Vector2((float)0.676116645, (float)0.307278931);

        Tool_UI_Min = new Vector2((float)0.322883427, (float)0.2318369);
        //Min Vector2(0.322883427,0.2318369)
        //Max Vector2(0.676116645,0.307278931)
        Tool_UI_OG_MAX = new Vector2((float)0.676116645, (float)0.199290469);
        Tool_UI_OG_MIN = new Vector2((float)0.322883427, (float)0.122290432);




        /*if (Object_sequence == null)
        {
            Debug.Log("Object sequence is null set in editor");
        }*/
    }


    // Update is called once per frame
    void Update()
    {
        //timeline.time == episodestartime 
        // if current time == endtime { increment bject++ Tl++

    }

    public void SB_Text_PLacement()
    {
        if (Small_Text_Count >= 0)
        {
            Small_text.GetComponent<TMP_Text>().text = Small_Dialog_Box[Small_Text_Count].ToString();
        }
        if (Text_Counter >= 0)
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[Text_Counter].ToString();
        }
    }

    public void Small_Text_To_Empty()
    {
        Small_text.GetComponent<TMP_Text>().text = "";
    }
    public void Close_Captioning_Button()
    {
        Close_Captioning = !Close_Captioning;

        if (Close_Captioning == true)
        {
            Small_Box_Tool.DOAnchorMax(Tool_UI_MAX,anim_Length);
            Small_Box_Tool.DOAnchorMin(Tool_UI_Min, anim_Length);

            Text_Frame.DOAnchorMax(Text_Frame_top_location, anim_Length);
            Big_text_Box.DOAnchorMax(Big_Text_Top_Location,  anim_Length);
            
            Small_text.SetActive(false);
            Big_Text.SetActive(true);
        }
        else
        {
            Small_Box_Tool.DOAnchorMax(Tool_UI_OG_MAX, anim_Length);
            Small_Box_Tool.DOAnchorMin(Tool_UI_OG_MIN, anim_Length);

            Text_Frame.DOAnchorMax(Text_Frame_location, anim_Length);
            Big_text_Box.DOAnchorMax(Big_text_OG, anim_Length);

            Small_text.SetActive(true);
            Big_Text.SetActive(false);
        }

        /*
         * Vector2(1,0.125127316)
         * Vector2(1,0.2318369)
         * */
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

            Play_Button.transform.GetComponent<Button>().interactable = true;

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
            simText.fontSize = 28;
            Big_text_Sim.fontSize = 28;
        }
        else if (Font_Counter == 1)
        {
            simText.fontSize = 30;
            Big_text_Sim.fontSize = 30;
        }
        else
        {
            simText.fontSize =35;
            Big_text_Sim.fontSize = 35;
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

            //Camera.transform.GetComponent<AudioListener>().enabled = false;
            Camera.transform.GetComponent<AudioSource>().mute = true;
        }
        else
        {
            Sound_Object.SetActive(true);

            Mute_Button.SetActive(false);

            //Camera.transform.GetComponent<AudioListener>().enabled = true;

            Camera.transform.GetComponent<AudioSource>().mute = false;
        }
    }

    public void MenuOptions()
    {
        M_Menu = !M_Menu;

        if (M_Menu == true)
        {
            Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);
            Menu_Block.SetActive(true);
            Camera.transform.GetComponent<Volume>().enabled = true;

        }
        else
        {

            Menu_Block.SetActive(false);
            Camera.transform.GetComponent<Volume>().enabled = false;

        }

    }

    public void Menu_NO()
    {
        M_Menu = false;
        Camera.transform.GetComponent<Volume>().enabled = false;
        Menu_Block.SetActive(false);
    }

    public void Drop_UI()
    {

    }

    public void Home_Button()
    {
        Application.OpenURL(EARTH_WEB);
    }


    public void Skip_Foward()
    {
        if (Object_num > 0)
        {
            Object_sequence[0].transform.GetComponent<Outline>().enabled = false;

            Object_sequence[0].transform.GetComponent<Collider>().enabled = false;
        }
        Debug.Log("Skip is active");

        if (Skip_Button_Num < TL_Max || Skip_Button_Num == -1)
        {
            Object_sequence[Object_num].transform.GetComponent<Outline>().enabled = false;

            Object_sequence[Object_num].transform.GetComponent<Collider>().enabled = false;

            //Back_Button.transform.GetComponent<Button>().interactable = true;

            Skip_Button_Num++;

            Text_Counter++;

            Small_Text_Count++;

            //Object_num++;

            Scene_Timeline.playableGraph.GetRootPlayable(0).SetTime(Timeline_Checkpoints[Skip_Button_Num]);
        }
        else
        {
            

        }

        for (int i = 0; i < Object_sequence.Length; i++)
        {
            if (Object_num == Object_num)
            {
                Object_sequence[Object_num].transform.GetComponent<Outline>().enabled = true;

                Object_sequence[Object_num].transform.GetComponent<Collider>().enabled = true;
            }
            else Object_sequence[Object_num].transform.GetComponent<Collider>().enabled = false; Object_sequence[Object_num].transform.GetComponent<Outline>().enabled = false;

        }




    }
    public void Skip_Back()
    {
        Debug.Log("Skip back is active");

            if (Object_num > 0)
            {
                Object_sequence[0].transform.GetComponent<Outline>().enabled = false;

                Object_sequence[0].transform.GetComponent<Collider>().enabled = false;
            }

            if (Skip_Button_Num >= TL_Min)
            {

                Object_sequence[Object_num].transform.GetComponent<Outline>().enabled = false;

                Object_sequence[Object_num].transform.GetComponent<Collider>().enabled = false;

                

                //Foward_Button.transform.GetComponent<Button>().interactable = true;

                Skip_Button_Num--;

                Object_num = Object_num - 2;

                Text_Counter--;

                Small_Text_Count--;

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

                Object_sequence[Object_num].transform.GetComponent<Outline>().enabled = false;

                Object_sequence[Object_num].transform.GetComponent<Collider>().enabled = false;

            }

            for (int i = 0; i < Object_sequence.Length; i++)
            {
                if (Object_num == Object_num)
                {
                    Object_sequence[Object_num].transform.GetComponent<Outline>().enabled = true;

                    Object_sequence[Object_num].transform.GetComponent<Collider>().enabled = true;
                }
                else Object_sequence[Object_num].transform.GetComponent<Collider>().enabled = false; Object_sequence[Object_num].transform.GetComponent<Outline>().enabled = false ;

            }

    }

    public void Skip_Activation()
    {
        //Foward_Button.transform.GetComponent<Button>().interactable = true;

        Back_Button.transform.GetComponent<Button>().interactable = true;

        Foward_Button.SetActive(true);

        Back_Button.SetActive(true);

        Foward_Dummy.SetActive(false);

        Back_Skip_Dummy.SetActive(false);
    }

    public void Play_Deactivation()
    {
        Play_Button.GetComponent<Button>().interactable = false;
    }
    public void Play_Activation()
    {

        Play_Button.GetComponent<Button>().interactable = true;
    }

    public void END_Of_Scene()
    {
        Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);

        Camera.transform.GetComponent<Volume>().enabled = true;

        End_Block.SetActive(true);
        
    }

    public void End_Replay()
    {
        End_Block.SetActive(false);
        Camera.transform.GetComponent<Volume>().enabled = false;
        Scene_Timeline.playableGraph.GetRootPlayable(0).SetTime(0);
        Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);
        Object_num = 0;
        Skip_Button_Num = 0;

}
}
