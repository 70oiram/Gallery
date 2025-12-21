using UnityEngine;

public class TeleportToggleOnR : MonoBehaviour
{
    bool goA = true; // true: 去A，false: 去B

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (goA)
                transform.position = new Vector3(15, 0, 48); // A點
            else
                transform.position = new Vector3(0, 0, 15);  // B點

            goA = !goA; // 下次換另一點
        }
    }
}
