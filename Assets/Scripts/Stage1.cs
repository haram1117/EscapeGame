using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1 : MonoBehaviour
{
    string objectName = "";
    bool objectTouch = false;
    public GameObject ObjScreen;
    public GameObject Comscreen_default;
    public GameObject Comscreen_369;
    public GameObject Clock_3;
    public GameObject Clock_6;
    public GameObject Clock_9;

    float clock_3_angle = 0;
    float clock_6_angle = 0;
    float clock_9_angle = 0;

    public GameObject hour_3;
    public GameObject hour_6;
    public GameObject hour_9;


    public InputField password;
    bool key_get = false;

    bool comclear = false;
    static bool clockclear = false;
//    private Collider hour_C;
//    float angle_h;
//    float angle_m;
//    Vector2 target, mouse;
    
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ObjScreen.activeSelf)
            GetPassword();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Out_Screen();
        }
        //Check_clock();
        clock_3_angle = Clock.clock_3_angle;
        clock_6_angle = Clock.clock_6_angle;
        clock_9_angle = Clock.clock_9_angle;
        Clock_Sync();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name != "CMRange")
        {/*
            if (collision.gameObject.name == "Computer1")
            {
                objectTouch = true;
                objectName = collision.gameObject.name;
            }
            if(collision.gameObject.name == "Clock_3")
            {
                objectTouch = true;
                objectName = collision.gameObject.name;
            }*/
            objectTouch = true;
            objectName = collision.gameObject.name;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        objectTouch = false;
        objectName = "";
        Out_Screen();//collision 밖으로 나가면 ObjScreen 비활
    }

    private void OnMouseDown()
    {
        if (objectTouch) //오브젝트 누르면 ObjScreen 활성화
        {
            Debug.Log(objectName);
            ObjScreen.SetActive(true);
            if (objectName == "Computer1")
            {
                if (comclear)
                    Comscreen_369.SetActive(true);
                else
                    Comscreen_default.SetActive(true);
            }
                
            else if (objectName == "Clock_3")
                Clock_3.SetActive(true);
            else if (objectName == "Clock_6")
                Clock_6.SetActive(true);
            else if (objectName == "Clock_9")
                Clock_9.SetActive(true);
            else if (objectName == "Key1")
            {
                Debug.Log("키 획득!");
                GameObject.Find("Key1").SetActive(false);
                key_get = true;
            }
        }
        
    }
    private void GetPassword()
    {
        if (password.text.ToString() == "12365874" && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            Comscreen_369.SetActive(true);
            comclear = true;
        }
    }

    //private void OnMouseDrag() // 시간 남으면 해보자,, 분침 마우스대로 움직이기..
    //{
    //    mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    angle_m = Mathf.Atan2(mouse.y, mouse.x) * Mathf.Rad2Deg * 10f; //mouse.y - target.y 혹시 모르니깐 이거 일단 기억
    //    angle_h = angle_m*0.0833333333f;
    //    minute.transform.rotation = Quaternion.AngleAxis(angle_m - 90, Vector3.forward);
    //    hour.transform.rotation = Quaternion.AngleAxis(angle_h - 90, Vector3.forward);
    //}
    private void Out_Screen()
    {
        ObjScreen.SetActive(false);
        Comscreen_369.SetActive(false);
        Comscreen_default.SetActive(false);
        Clock_3.SetActive(false);
        Clock_6.SetActive(false);
        Clock_9.SetActive(false);
    }

    //private void Check_clock()
    //{
    //    Debug.Log("3: " + clock_clear3 + " 6: " + clock_clear6 + " 9: " + clock_clear9);
    //    //Debug.Log(hour_3.transform.rotation.z);
    //    if (hour_3.transform.rotation.z == -90)
    //        clock_clear3 = true;
    //    else if (hour_3.transform.rotation.z != -90 && Clock_3.activeSelf)
    //        clock_clear3 = false;

    //    if (hour_6.transform.rotation.z == 180)
    //        clock_clear6 = true;
    //    else if (hour_6.transform.rotation.z != 180)
    //        clock_clear6 = false;

    //    if (hour_9.transform.rotation.z == 90)
    //        clock_clear9 = true;
    //    else if (hour_3.transform.rotation.z != 90)
    //        clock_clear9 = false;

    //    if (clock_clear3 && clock_clear6 && clock_clear9)
    //    {
    //        Debug.Log("Clock Clear!");
    //    }
    //}
    private void Clock_Sync()
    {
        Debug.Log(clock_3_angle);
        hour_3.transform.rotation = Quaternion.Euler(hour_3.transform.rotation.x, hour_3.transform.rotation.y, clock_3_angle);
        hour_6.transform.rotation = Quaternion.Euler(hour_6.transform.rotation.x, hour_6.transform.rotation.y, clock_6_angle);
        hour_9.transform.rotation = Quaternion.Euler(hour_9.transform.rotation.x, hour_9.transform.rotation.y, clock_9_angle);
    }
}
