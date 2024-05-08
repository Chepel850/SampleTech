using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;


public class Uncollapsed_Captioning : MonoBehaviour
{
    
    //public string UN_Coll_Sub;

    public GameObject Big_Text;

    public GameObject Small_Text;


    [SerializeField]
    [TextArea]
    public List<string> Large_Dialog_Box;

    [SerializeField]
    public List<double> dialog_Checkpoints;

    [SerializeField]
    [TextArea]
    public List<string> Small_Dialog_Box;

    [SerializeField]
    public List<double> Small_Text_Checkpoints;


    public int Text_Counter = 0;

    [SerializeField]
    PlayableDirector Scene_Timeline;

    // Start is called before the first frame update
    void Start()
    {
        Text_Counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Text_Placement();
        Small_Text_Placement();
    }


    public void Text_Placement()
    {
        if (Scene_Timeline.time >= dialog_Checkpoints[0] && Scene_Timeline.time <= dialog_Checkpoints[1])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[0].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[2] && Scene_Timeline.time <= dialog_Checkpoints[3])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[1].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[4] && Scene_Timeline.time <= dialog_Checkpoints[5])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[2].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[6] && Scene_Timeline.time <= dialog_Checkpoints[7])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[3].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[8] && Scene_Timeline.time <= dialog_Checkpoints[9])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[4].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[10] && Scene_Timeline.time <= dialog_Checkpoints[11])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[5].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[12] && Scene_Timeline.time <= dialog_Checkpoints[13])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[6].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[14] && Scene_Timeline.time <= dialog_Checkpoints[15])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[7].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[16] && Scene_Timeline.time <= dialog_Checkpoints[17])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[8].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[18] && Scene_Timeline.time <= dialog_Checkpoints[19])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[9].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[20] && Scene_Timeline.time <= dialog_Checkpoints[21])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[10].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[22] && Scene_Timeline.time <= dialog_Checkpoints[23])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[11].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[24] && Scene_Timeline.time <= dialog_Checkpoints[25])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[12].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[26] && Scene_Timeline.time <= dialog_Checkpoints[27])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[13].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[28] && Scene_Timeline.time <= dialog_Checkpoints[29])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[14].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[30] && Scene_Timeline.time <= dialog_Checkpoints[31])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[15].ToString();
        }
        //-----
        else if (Scene_Timeline.time > dialog_Checkpoints[32] && Scene_Timeline.time <= dialog_Checkpoints[33])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[16].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[34] && Scene_Timeline.time <= dialog_Checkpoints[35])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[17].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[36] && Scene_Timeline.time <= dialog_Checkpoints[37])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[18].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[38] && Scene_Timeline.time <= dialog_Checkpoints[39])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[19].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[40] && Scene_Timeline.time <= dialog_Checkpoints[41])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[20].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[42] && Scene_Timeline.time <= dialog_Checkpoints[43])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[21].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[44] && Scene_Timeline.time <= dialog_Checkpoints[45])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[22].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[46] && Scene_Timeline.time <= dialog_Checkpoints[47])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[23].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[48] && Scene_Timeline.time <= dialog_Checkpoints[49])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[24].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[50] && Scene_Timeline.time <= dialog_Checkpoints[51])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[25].ToString();
        }
        //------
        else if (Scene_Timeline.time > dialog_Checkpoints[52] && Scene_Timeline.time <= dialog_Checkpoints[53])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[26].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[54] && Scene_Timeline.time <= dialog_Checkpoints[55])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[27].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[56] && Scene_Timeline.time <= dialog_Checkpoints[57])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[28].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[58] && Scene_Timeline.time <= dialog_Checkpoints[59])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[29].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[60] && Scene_Timeline.time <= dialog_Checkpoints[61])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[30].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[62] && Scene_Timeline.time <= dialog_Checkpoints[63])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[31].ToString();
        }
        //-----
        else if (Scene_Timeline.time > dialog_Checkpoints[64] && Scene_Timeline.time <= dialog_Checkpoints[65])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[32].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[66] && Scene_Timeline.time <= dialog_Checkpoints[67])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[33].ToString();
        }
        else if (Scene_Timeline.time > dialog_Checkpoints[68] && Scene_Timeline.time <= dialog_Checkpoints[69])
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[34].ToString();
        }
      


        else Big_Text.GetComponent<TMP_Text>().text = "";



    }
   
    public void Small_Text_Placement()
    {
        if (Scene_Timeline.time >= Small_Text_Checkpoints[0] && Scene_Timeline.time <= Small_Text_Checkpoints[1])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[0].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[2] && Scene_Timeline.time <= Small_Text_Checkpoints[3])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[1].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[4] && Scene_Timeline.time <= Small_Text_Checkpoints[5])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[2].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[6] && Scene_Timeline.time <= Small_Text_Checkpoints[7])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[3].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[8] && Scene_Timeline.time <= Small_Text_Checkpoints[9])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[4].ToString();
        }
        //-------------------------------
        else if (Scene_Timeline.time > Small_Text_Checkpoints[10] && Scene_Timeline.time <= Small_Text_Checkpoints[11])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[5].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[12] && Scene_Timeline.time <= Small_Text_Checkpoints[13])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[6].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[14] && Scene_Timeline.time <= Small_Text_Checkpoints[15])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[7].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[16] && Scene_Timeline.time <= Small_Text_Checkpoints[17])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[8].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[18] && Scene_Timeline.time <= Small_Text_Checkpoints[19])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[9].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[20] && Scene_Timeline.time <= Small_Text_Checkpoints[21])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[10].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[22] && Scene_Timeline.time <= Small_Text_Checkpoints[23])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[11].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[24] && Scene_Timeline.time <= Small_Text_Checkpoints[25])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[12].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[26] && Scene_Timeline.time <= Small_Text_Checkpoints[27])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[13].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[28] && Scene_Timeline.time <= Small_Text_Checkpoints[29])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[14].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[30] && Scene_Timeline.time <= Small_Text_Checkpoints[31])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[15].ToString();
        }
        else if (Scene_Timeline.time > Small_Text_Checkpoints[32] && Scene_Timeline.time <= Small_Text_Checkpoints[33])
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[16].ToString();
        }
        else Small_Text.GetComponent<TMP_Text>().text = "";
    }
    




    
}
