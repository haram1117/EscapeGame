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
    public InputField password;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ObjScreen.activeSelf)
            GetPassword();
        if (Input.GetKeyDown(KeyCode.Escape))
            ObjScreen.SetActive(false);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name != "CMRange")
        {
            if (collision.gameObject.name == "Computer1")
            {
                objectTouch = true;
                objectName = collision.gameObject.name;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        objectTouch = false;
        objectName = "";
        ObjScreen.SetActive(false);//collision 밖으로 나가면 ObjScreen 비활
    }

    private void OnMouseDown()
    {
        if (objectTouch) //오브젝트 누르면 ObjScreen 활성화
        {
            Debug.Log(objectName);
            ObjScreen.SetActive(true);
            Comscreen_default.SetActive(true);
        }
    }
    private void GetPassword()
    {
        if (password.text.ToString() == "12365874" && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)))
            Comscreen_369.SetActive(true);
    }


}
