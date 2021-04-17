using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Clock : MonoBehaviour, IPointerClickHandler
{
    public GameObject hour;
    int temp = 0;
    public static float clock_3_angle = 0;
    public static float clock_6_angle = 0;
    public static float clock_9_angle = 0;

    bool clockclear = false;
    bool clock_clear3 = false;
    bool clock_clear6 = false;
    bool clock_clear9 = false;

    public GameObject hour_3;
    public GameObject hour_6;
    public GameObject hour_9;
    public GameObject Dclock;
    public Sprite digitalclock;


    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!clockclear)
        {
            temp++;
            hour.transform.rotation = Quaternion.Euler(hour.transform.rotation.x, hour.transform.rotation.y, -30 * temp);
            clock_3_angle = hour_3.transform.rotation.eulerAngles.z;
            clock_6_angle = hour_6.transform.rotation.eulerAngles.z;
            clock_9_angle = hour_9.transform.rotation.eulerAngles.z;
        }
        
        if (clock_3_angle == 270)
            clock_clear3 = true;
        else
            clock_clear3 = false;

        if (clock_6_angle == 180)
            clock_clear6 = true;
        else
            clock_clear6 = false;

        if (clock_9_angle == 90)
            clock_clear9 = true;
        else
            clock_clear9 = false;
        if (clock_clear3 && clock_clear6 && clock_clear9)
        {
            clockclear = true;
            Dclock.GetComponent<SpriteRenderer>().sprite = digitalclock;
        }
            
    }
}
