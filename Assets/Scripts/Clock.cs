using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Clock : MonoBehaviour, IPointerClickHandler
{
    public GameObject hour;
    int temp = 0;

    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("mouse Click");
        temp++;
        hour.transform.rotation = Quaternion.Euler(hour.transform.rotation.x, hour.transform.rotation.y, -30*temp);
    }
}
