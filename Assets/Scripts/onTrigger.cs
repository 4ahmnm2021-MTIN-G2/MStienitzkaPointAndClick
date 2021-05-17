using UnityEngine;
using UnityEngine.UI;

public class onTrigger : MonoBehaviour {
  public GameObject can;
  public GameObject Zeitung;
  public Text objectText;
  public string cylinderout;
  public string ballout;
  public string binInteractText;
  public string cylInteractText;
  private bool bin = false;
  private bool bintext = false;
  private bool cylindertext = false;
  private bool clue1 = false;
  private bool clue2 = false;
  private bool cyl = false;

  //Check Collider
  void OnTriggerEnter (Collider target) {
    if (target.tag == "Interactable") {
      can.SetActive (true);
      bin = true;
      if (bintext == true) {
        objectText.text = ballout;
        Debug.Log ("trigger enter");

      }
    }
    if (target.tag == "Cylinder") {
      can.SetActive (true);
      cyl = true;
      if (cylindertext == true) {
        objectText.text = cylinderout;
      }
      Debug.Log ("cylinder exit");
    }
  }
  void OnTriggerExit (Collider target) {
    if (target.tag == "Interactable") {
      can.SetActive (false);
      bin = false;
      Debug.Log ("trigger exit");
      objectText.text = "???";
    }
    if (target.tag == "Cylinder") {
      can.SetActive (false);
      cyl = false;
      Debug.Log ("cylinder exit");
      objectText.text = "???";
    }
  }

  public void Inspect () {
    if (bin == true) {

      objectText.text = ballout;
      bintext = true;
    }
    if (cyl == true) {
      objectText.text = cylinderout;
      cylindertext = true;
    }
  }

  public void Interact () {
    if (bin && bintext) {
      ballout = binInteractText;
      objectText.text = binInteractText;
      clue1 = true;
      Zeitung.SetActive (false);
    }
     if (cyl && cylindertext) {
      cylinderout = cylInteractText;
      objectText.text = cylInteractText;
      clue2 = true; 
    }
  }

  void Update()
  {
    if(clue1 && clue2){
      Debug.Log("NextLevel");
    }
  }
}