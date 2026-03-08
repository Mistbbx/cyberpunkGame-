using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public static GameObject dropZoneObject = null;
    public static Transform dropZoneTransform = null;

    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        if (TurnSystem.isYourTurn)
        {
            Debug.Log("Drop");
            //dropZoneObject = eventData.pointerCurrentRaycast.gameObject;
            dropZoneObject = this.gameObject;
            
            
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        
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
