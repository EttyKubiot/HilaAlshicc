using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LineScale : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private GameManager gameManager;

    private Vector2 startPosition;
   
    //private bool isObjectAlreadyScaled = false;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = Vector2.zero;
    }

    public void OnDrag(PointerEventData eventData)
    {
       
        if (/*!isObjectAlreadyScaled &&*/ transform.localScale.x <= 1.4f)
        {
            startPosition += eventData.delta;
            Color tmp = GetComponent<Image>().color;
            tmp.a = 255f;
            GetComponent<Image>().color = tmp;
            var newScale = new Vector3(
            transform.localScale.x * 1.1f,
            transform.localScale.y,
            transform.localScale.z);

            // Set scale to the new Vector3.
            transform.localScale = newScale;
          
            //    transform.localScale =  (Vector3)scalingAmount * scalingFactor;
        }
        //if (transform.localScale.x >= 1.4f)
        //{
          
        //}
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        gameManager.OnDraw?.Invoke();
    }
}
