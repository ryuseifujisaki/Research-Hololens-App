using System.IO;
using System.Text;
using UnityEngine;
using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;


public class OutputCsv : MonoBehaviour
{
    private StreamWriter sw;
    DateTime dt;
    // Start is called before the first frame update
    void Start()
    {
        dt = DateTime.Now;
        string DateNowFormat = dt.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
        sw = new StreamWriter(@$"{DateNowFormat}.csv", false, Encoding.GetEncoding("Shift_JIS"));
    }

    public void SaveData(string txt1, string txt2, string txt3)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
