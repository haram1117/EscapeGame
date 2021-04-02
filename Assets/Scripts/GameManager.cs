using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //public GameObject option_button;
    //public GameObject option_Sound;
    public GameObject option_screen;
    private bool sound = true;
    private void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        if (gameObject.name == "Square")
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            option_screen.SetActive(true);
        }
        else if(gameObject.name == "Sound")
        {
            if (sound)
            {
                Debug.Log("Sound Off");
                sound = false;
            }
            else
            {
                Debug.Log("Sound On");
                sound = true;
            }
        }
        else if(gameObject.name == "Back")
            option_screen.SetActive(false);
        else 
            SceneManager.LoadScene("GameScenes");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
    }
}
