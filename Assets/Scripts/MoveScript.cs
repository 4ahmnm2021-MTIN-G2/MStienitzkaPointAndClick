using System.Net;
using UnityEngine;
using DG.Tweening;

public class MoveScript : MonoBehaviour
{
 public Camera cam;
 public GameObject Cube;
 public float time;

    void Update()
    {
      if (Input.GetMouseButtonDown(0))  {

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
            Cube.transform.DOMove(hit.point, 0.5f);
            Debug.Log("LOLOL");
            }
        
      }
      
    }
}
