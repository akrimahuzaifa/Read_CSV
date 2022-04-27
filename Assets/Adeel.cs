using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adeel : Random
{
    public int xyz;
    public CSVReader r;
    private void Reset()
    {

        r = FindObjectOfType<CSVReader>();
    }
}
