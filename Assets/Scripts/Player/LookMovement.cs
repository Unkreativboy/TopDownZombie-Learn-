using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMovement : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayerMask;

    //For caching
    private Camera camera;
    private Ray ray;

    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        
       ray = camera.ScreenPointToRay(GameInput.Instance.GetMousePosition());

        if(Physics.Raycast(ray, out RaycastHit hitData))
        {
            Vector2 mouseDirection = new Vector2(transform.position.x, transform.position.z) - new Vector2(hitData.point.x, hitData.point.z);
            float degrees = Mathf.Atan2(mouseDirection.y, mouseDirection.x)*Mathf.Rad2Deg+90f;
            Debug.Log(degrees);

            transform.eulerAngles = new Vector3(0, -degrees, 0);

        }

        
        
    
    }



}
