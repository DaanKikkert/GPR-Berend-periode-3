using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RayCastFromCamera : MonoBehaviour
{
    [SerializeField] private UnityEvent hitPlayer;
    private Ray mouseRay;
    private RaycastHit hit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.green);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "Player")
                {
                    Debug.Log("hit");
                    hitPlayer.Invoke();
                }
            }
        }
    }
}
