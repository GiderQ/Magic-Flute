using UnityEngine;

public class DoorTeleport : MonoBehaviour
{
    
    [SerializeField] private Transform playerTarget;
    [SerializeField] private Transform cameraTarget; 

    
    [SerializeField] private string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            
            if (playerTarget != null)
                other.transform.position = playerTarget.position;

           
            if (cameraTarget != null && Camera.main != null)
            {
                Camera.main.transform.position = new Vector3(
                    cameraTarget.position.x,
                    cameraTarget.position.y,
                    Camera.main.transform.position.z 
                );
            }
        }
    }
}
