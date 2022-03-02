using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCAm : MonoBehaviour
{
    Vector2 touchDeltaPosition;
    void Start()
    {
        
    }

    bool val = false;
    void Update() {
         if (Input.GetMouseButton(1) && transform.position.x<=1940)
           {
               float pointer_x = Input.GetAxis("Mouse X");
               float pointer_y = Input.GetAxis("Mouse Y");
               transform.Translate(-pointer_x * 10f,
                           -pointer_y * 10f, 0);
           }
        if (transform.position.x >= 820 && transform.position.x >= 825) {
            transform.Translate(-1* 10f,0,0);
        }
        if (transform.position.x <= -815 && transform.position.x <= -820)
        {
            transform.Translate(1 * 10f, 0, 0);
        }
        if (transform.position.y <= -945 && transform.position.y <= -940)
        {
            transform.Translate(0, 1 * 10f, 0);
        }
        if (transform.position.y >= -300 && transform.position.y >= -295)
        {
            transform.Translate(0, -1 * 10f, 0);
        }

            if (Input.touchCount == 1)
            {
                Touch touchZero = Input.GetTouch(0);
                if (touchZero.phase == TouchPhase.Moved)
                {
                    touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                    gameObject.transform.Translate(touchDeltaPosition.x * 1f, touchDeltaPosition.y * 1, 0);
                }
            }
        
    }
   
    

}
