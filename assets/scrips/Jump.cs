using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;




public class Jump : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    
    bool isPressed = false;
    public GameObject Player;
    public float Force;

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            Player.transform.Translate(0,Force*Time.deltaTime,0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();  
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    
    }

     public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    
    }
}