using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userinputmanager : MonoBehaviour {

    void FixedUpdate() {
        RaycastHit hit;
        //Ray ray = new Ray(transform.position, transform.forward);

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        if (Physics.Raycast(ray, out hit, 100))
            Debug.DrawLine(ray.origin, hit.point);
            Debug.Log(hit.collider.gameObject.name);

        //print(hit.collider.gameObject.name);


        //if (Physics.Raycast(ray, out hit)) //(Physics.Raycast(ray.direction, hit, 1000)) 
        //  {
        //    Debug.Log(hit.collider.gameObject.name);
        //}

        //if (Physics.Raycast(transform.position, -Vector3.up, out hit)) {
        //    Debug.Log(hit.collider.gameObject.name);
        //}

        //if (Physics.Raycast(transform.position, -Vector3.up, out hit)) {
        //    if (Input.GetButtonDown("Oculus_CrossPlatform_Button2")) {
        //        Debug.Log("Oculus_CrossPlatform_Button2");
        //        Debug.Log(hit.collider.gameObject.name);




        //} else if (Input.GetButtonDown("Oculus_CrossPlatform_Button4")) {
        //    Debug.Log("Oculus_CrossPlatform_Button4");
        //     Debug.Log(hit.collider.gameObject.name);

        //  }
        //  }
    }
}
