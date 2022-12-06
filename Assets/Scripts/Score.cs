using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] TMP_Text scoreLabel;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z < 0)
        {
            
            scoreLabel.text = "0";

        }
        else
        {
            scoreLabel.text = player.transform.position.z.ToString("0");
        }
    }
}
