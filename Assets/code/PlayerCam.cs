using UnityEngine;

public class PlayerCam : MonoBehaviour
{   public float sensX;
    public float sensX;
    
    public Transfrom orientation;

    float xRotation;
    float yRotation;

   privte void Start()
   {
       Cursor.lockstate = CursorLockMode.Locked;
       Cursor.visible = false;
   }

   privte void Update()
   {
       // get mouse input
       float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
       float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

       yRotation += mouseX;
      
       xRotation += mouseY;
       xRotation = Mathf. Clamp(xRotation, -90f,90f);

       // rotate cam and orientation
       transfrom.rotation = Quaternion.Euler(xRotation, yRotation, 0);
       orientation.rotation = Quaternion.Euler(0, yRotation, 0);


       
   }
}
