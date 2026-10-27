using UnityEngine;

public class Movecamera : MonoBehaviour
{
   public Transform cameraPosition;

   private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
