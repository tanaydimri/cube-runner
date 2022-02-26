using UnityEngine;
using UnityEngine.UIElements;

public class DeviceInputHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameEvents.current.FireABullet();
        }
    }
}
