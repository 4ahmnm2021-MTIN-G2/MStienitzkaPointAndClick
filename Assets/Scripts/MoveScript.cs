using System;
using System.Net;
using UnityEngine;
using DG.Tweening;

public class MoveScript : MonoBehaviour
{
 public Camera cam;
 public GameObject Cube;
 public float time;
 public GameObject Canvas;
 public Collider coll;

    void Update()
    {
      if (Input.GetMouseButtonDown(0))  {

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (coll.Raycast(ray, out hit, 100.0f))
            {
            Cube.transform.DOMove(hit.point, time);
            Debug.Log("Move");
            }
        
      }
    }
void OnTriggerEnter(Collider target)
{
  if(target.tag == "Interactable"){
    Canvas.SetActive(true );
    Debug.Log("trigger");
  }
}
}

