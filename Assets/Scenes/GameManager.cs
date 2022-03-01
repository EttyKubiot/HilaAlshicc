using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityAction OnDraw;
    private int numDraw = 0;
    [SerializeField] private GameObject[] lineShape;
    [SerializeField] private GameObject[] lineMistake;
    void Start()
    {
        OnDraw += EndDrawLines;
    }

    // Update is called once per frame
    public void EndDrawLines()
    {
       
        if(numDraw < 6)
        {
            numDraw = numDraw+1;
            Debug.Log(numDraw);
            return;
        }
        else
        {
            for (int i = 0; i < lineMistake.Length; i++)
            {

                lineMistake[i].GetComponent<Transform>().localScale = new Vector3(0.2f, 0.2f, 0.2f);

            }
        }
        
        
    }


}
