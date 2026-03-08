using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;
    public GameObject thisObject;
    public int _identifier;
    public static bool costMet;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (TurnSystem.isYourTurn)
        {
            
            parentToReturnTo = this.transform.parent;
            DropZone.dropZoneObject = this.transform.parent.gameObject;
            this.transform.SetParent(this.transform.parent.parent);
            this.gameObject.name = "test";
            Debug.Log(GameObject.Find("test").GetComponent<DisplayCard>().cost + " " + TurnSystem.currentMana);
            if(GameObject.Find("test").GetComponent<DisplayCard>().cost <= TurnSystem.currentMana) costMet=true;
            else costMet = false;
            GetComponent<CanvasGroup>().blocksRaycasts = false;
            Debug.Log(costMet);
            
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
            if(costMet){ 
                this.transform.SetParent(DropZone.dropZoneObject.transform);
                if(DropZone.dropZoneObject.transform != parentToReturnTo)
                {
                    TurnSystem.currentMana-=GetComponent<DisplayCard>().cost;
                    OppHp.oppStaticHp-=GetComponent<DisplayCard>().power;
                    Destroy(this.gameObject);
                }
            }
            else {
                this.transform.SetParent(parentToReturnTo);
            }
            //this.transform.SetParent(parentToReturnTo);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            //_identifier = DropZone.dropZoneObject.GetComponentInChildren<DisplayCard>().id;
            //Debug.Log(_identifier);
            this.gameObject.name = "test1";
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
