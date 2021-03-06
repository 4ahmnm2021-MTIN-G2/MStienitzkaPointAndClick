using DG.Tweening;
using UnityEngine;

public class MoveScript : MonoBehaviour {
  public Camera cam;
  public GameObject cube;
  public float time;
  public GameObject Canvas;
  public Collider coll;
  public float oldPos;
  public float newPos;
  public float velocity;
    public Animator animator; 

  void Update () {
    if(Canvas.activeSelf == false){
     if (Input.GetMouseButtonDown (0)) {

      Ray ray = cam.ScreenPointToRay (Input.mousePosition);
      RaycastHit hit;
      oldPos = cube.transform.position.magnitude;
      if (coll.Raycast (ray, out hit, 100.0f)) {
        cube.transform.DOMove (hit.point, time);
        Debug.Log ("Move");
        animator.SetBool("IsWalking", true);
      }

    }
    if (Input.GetMouseButtonUp (0)) {
      newPos = cube.transform.position.magnitude;
      velocity = oldPos - newPos / time;
    }    
    }
  }
 public void ExitButton(){
  Canvas.SetActive(false);
 }
}