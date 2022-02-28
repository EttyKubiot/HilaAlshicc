using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstyTest : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private EstyLine line;

    private void Start()
    {
        line.SetUpLine(points);
    }
}
