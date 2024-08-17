using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    
    public int appleCount;
    public Text appleText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        appleText.text = "Pearl Score: " + appleCount.ToString();

       
    }
}
