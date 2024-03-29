using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle_rtotation : MonoBehaviour
{


    [SerializeField]
    GameObject bottle_1;

    [SerializeField]
    GameObject bottle_2;

    [SerializeField]
    GameObject bottle_3;

    public float speed_R = 6f;

    public float Rotate_Angle = -45f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tilt_Z = Input.GetAxis("Horizontal") * Rotate_Angle;
        float tilt_x = Input.GetAxis("Vertical") * Rotate_Angle;

        Quaternion B_Object = Quaternion.Euler(tilt_x, tilt_Z , -90);

        bottle_1.transform.rotation = Quaternion.Slerp(transform.rotation, B_Object, Time.deltaTime * speed_R);

        First_Bottle_Rotation();
        Second_Bottle_Rotation();
        Third_Bottle_Rotation();
    }

    public void First_Bottle_Rotation()
    {

        bottle_1.transform.RotateAround(bottle_1.transform.position,  Vector3.up, Rotate_Angle);
    }

    public void Second_Bottle_Rotation()
    {
        bottle_2.transform.Rotate(0, speed_R ,0);
    }

    public void Third_Bottle_Rotation()
    {
        bottle_3.transform.Rotate(0, speed_R ,0);
    }
  
}
