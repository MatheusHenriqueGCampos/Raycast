using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit)) {
                IHittable hitObject = hit.collider.gameObject.GetComponent<IHittable>();
                if (hit.collider.gameObject.layer == 6 && hitObject != null)
                {
                    hitObject.OnHit();
                }
            }
        }       
    }
}
