using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onTrigger : MonoBehaviour
{
public GameObject can;
public Text objectText;
public string cylinderout;
public string ballout;
private bool ball = false;
private bool balltext = false;
private bool cylindertext = false;
private bool cyl = false;

//Check Collider
void OnTriggerEnter(Collider target)
{
  if(target.tag == "Interactable"){
    can.SetActive(true );
    ball = true;
    if (balltext == true){
    objectText.text = ballout;
    Debug.Log("trigger enter");
   
    }
  }
   if(target.tag == "Cylinder"){
    can.SetActive(true );
    cyl = true;
    if (cylindertext == true){
    objectText.text = cylinderout;
    }
    Debug.Log("cylinder exit");
  }
}
void OnTriggerExit(Collider target)
{
  if(target.tag == "Interactable"){
    can.SetActive(false );
    ball = false;
    Debug.Log("trigger exit");
    objectText.text = "???";
  }
     if(target.tag == "Cylinder"){
    can.SetActive(false );
    cyl = false;
    Debug.Log("cylinder exit");
    objectText.text = "???";
}    
}

public void Inspect(){
    if(ball == true){

        objectText.text = ballout;
        balltext = true;
    }
    if(cyl == true){
        objectText.text = cylinderout;
        cylindertext = true;
}
}
}