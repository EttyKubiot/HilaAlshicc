using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class LineScaleZ : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    [SerializeField] private GameManager gameManager;
    private Vector2 startPosition;

    //private bool isObjectAlreadyScaled = false;
    private void Start()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = Vector2.zero;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (/*!isObjectAlreadyScaled &&*/ transform.localScale.x <= 2.0f)
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
            gameManager.OnDraw?.Invoke();
            //    transform.localScale =  (Vector3)scalingAmount * scalingFactor;
        }
    }

}
