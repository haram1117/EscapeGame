using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1 : MonoBehaviour
{
    string objectName = "";
    bool objectTouch = false;
    public GameObject ObjScreen;
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
        ObjScreen.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (objectTouch)
        {
            Debug.Log(objectName);
            ObjScreen.SetActive(true);
        }
    }
    private void GetPassword()
    {
        if (password.text.ToString() == "12365874")
            Debug.Log("clear!");
    }


}
