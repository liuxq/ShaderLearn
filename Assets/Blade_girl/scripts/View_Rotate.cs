using UnityEngine;
using System.Collections;

public class View_Rotate : MonoBehaviour
{

    public GameObject guiObject;
    private Vector2 rotationVelocity;

    void Start()
    {

    }

    void Update()
    {

        bool clickingButton = false;
       
        if (!clickingButton && (Input.GetMouseButton(0) || Input.GetMouseButton(1)))
        {    //Velocity 速率；迅速；周转率
            rotationVelocity.x += Mathf.Pow(Mathf.Abs(Input.GetAxis("Mouse X")), 1.5f) * Mathf.Sign(Input.GetAxis("Mouse X"));
            rotationVelocity.y -= Input.GetAxis("Mouse Y") * 0.04f;
        }
        transform.position += new Vector3(0, rotationVelocity.y,0);
        transform.RotateAround(Vector3.zero, Vector3.up, rotationVelocity.x);
        rotationVelocity = Vector2.Lerp(rotationVelocity, Vector2.zero, Time.deltaTime * 10.0f);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 0, 5), transform.position.z) ;
        transform.LookAt(new Vector3(0, 1, 0));


    }
}
