using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggandDropSystem : MonoBehaviour
{
    private bool isDragActive=false;
    private Vector2 screenPos;
    private Vector3 WorldPos;
    private CanDragg DragObject;
    // Start is called before the first frame update
    void Start()
    {
        DraggandDropSystem[] controller = FindObjectsOfType<DraggandDropSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        if(isDragActive && (Input.GetMouseButtonDown(0) || (Input.GetTouch(0).phase == TouchPhase.Ended)))
        {
            Drop();
            return;
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            screenPos = new Vector2(mousePos.x,mousePos.y);

        }
        else if (Input.touchCount>0)
        {
            screenPos = Input.GetTouch(0).position;
        }
        else
        {
            return;
        }

        WorldPos= Camera.main.ScreenToWorldPoint(screenPos);
        if(isDragActive)
        {
            Drag();
        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(WorldPos, Vector2.zero); 
            if(hit.collider!= null)
            {
                CanDragg canDragg = hit.transform.gameObject.GetComponent<CanDragg>();
                if(canDragg != null)
                {
                    DragObject = canDragg;
                    InDrag();
                }
            }

        }
    }

    public void InDrag()
    {
        isDragActive = true;
    }

    public void Drag()
    {
        DragObject.transform.position = new Vector2(WorldPos.x, WorldPos.y);
    }
    public void Drop()
    {
        isDragActive = false;   
    }

}
