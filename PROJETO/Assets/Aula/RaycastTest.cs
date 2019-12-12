using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     //   Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
     /*   RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
        
        if(hit.collider != null)
        {
            Debug.DrawLine(transform.position, hit.point, Color.green);
        }
        else
        {
            Debug.DrawLine(transform.position, transform.right, Color.red);
        }


        RaycastHit hit3D;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit3D))
        {
            Debug.Log(hit3D.Transform.name);
        }
       */
    }
}
