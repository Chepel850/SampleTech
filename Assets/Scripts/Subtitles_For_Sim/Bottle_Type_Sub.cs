using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Bottle_Type_Sub : MonoBehaviour
{
    public string Coll_Sub;

    public string UN_Coll_Sub;

    public GameObject Big_Text;

    public GameObject Small_Text;

    [SerializeField]
    [TextArea]
    public List<string> Large_Dialog_Box;

    [SerializeField]
    [TextArea]
    public List<string> Small_Dialog_Box;

    public int Text_Counter = 0;
    public int Small_Text_Count = 0;

    // Start is called before the first frame update
    void Start()
    {
        Text_Counter = 0;
        Small_Text_Count = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Text_Placement()
    {

        if (Text_Counter >= 0)
        {
            Big_Text.GetComponent<TMP_Text>().text = Large_Dialog_Box[Text_Counter].ToString();
        }

        
        
    }

    public void Small_Text_Placement()
    {
        if (Small_Text_Count >= 0)
        {
            Small_Text.GetComponent<TMP_Text>().text = Small_Dialog_Box[Small_Text_Count].ToString();
        }
    }
    public void Small_Text_To_Empty()
    {
        Small_Text.GetComponent<TMP_Text>().text = "";
    }

    public void Text_COunter_Add()
    {
        Text_Counter++;
    }
    public void Small_Text_Counter()
    {
        Small_Text_Count++;
    }




    
}
