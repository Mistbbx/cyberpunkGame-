using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Transform parentToReturnTo = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (TurnSystem.isYourTurn)
        {
        
            parentToReturnTo = this.transform.parent;
            DropZone.dropZone = parentToReturnTo;
            this.transform.SetParent(this.transform.parent.parent);
            GetComponent<CanvasGroup>().blocksRaycasts = false;
            Debug.Log("Drag");
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (TurnSystem.isYourTurn)
        {
            //Debug.Log("Drag");
            this.transform.position = eventData.position;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (TurnSystem.isYourTurn)
        {
            this.transform.SetParent(DropZone.dropZone);
            //this.transform.SetParent(parentToReturnTo);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
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
