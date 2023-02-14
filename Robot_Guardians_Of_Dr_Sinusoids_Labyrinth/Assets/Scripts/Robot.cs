using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Robot : MonoBehaviour

{

    public string text;
    private AudioSource audio;


    public void OnTriggerEnter2D(Collider2D collider2D) {
        print("Entered..");
        audio.Play();
        if (collider2D.gameObject.CompareTag("Player")) {
            GameManager.Instance.DialogShow(text);
        }
    }
    public void OnTriggerExit2D(Collider2D collider2D) {
        if (collider2D.gameObject.CompareTag("Player")) {
            GameManager.Instance.DialogHide();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
