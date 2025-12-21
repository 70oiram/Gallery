using UnityEngine;

public class TeleportPlayerFromEmpty : MonoBehaviour
{
    public Transform player;   // 把玩家物件拖到這裡
    bool goA = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (goA)
                player.position = new Vector3(15, 0, 48);
            else
                player.position = new Vector3(0, 0, 15);

            goA = !goA;
        }
    }
}
