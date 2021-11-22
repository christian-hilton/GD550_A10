using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameOverText : MonoBehaviour
{

    private Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        print("start");
        text = GameObject.Find("CompleteText").GetComponent<Text>();

        text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("trigger");

        text.gameObject.SetActive(true);
    }
}
