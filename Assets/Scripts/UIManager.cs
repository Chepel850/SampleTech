using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI simText;
    public Slider textSlider;

    [SerializeField]
    Button Options_Button;

    [SerializeField]
    Button Foward_Button;

    [SerializeField]
    Button Back_Button;

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



    public bool M_Menu= false;

    public bool sound_Mute = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTextSize()
    {
        simText.fontSize = textSlider.value;
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
            Scene_Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
            Menu_Block.SetActive(false);
               
        }
    }

    public void Drop_UI()
    {

    }
}
