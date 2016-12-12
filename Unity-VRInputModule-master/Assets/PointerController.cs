using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;


public class PointerController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    public  GameObject halo;
    public  GameObject graphic;

    /*public void Start()
    {
        halo.SetActive(false);
    } */


    public void OnPointerEnter(PointerEventData eventData)
    {
        halo.SetActive(true);
        graphic.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        halo.SetActive(false);
        graphic.SetActive(false);
    }
}
