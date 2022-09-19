using UnityEngine;

public class Wheel : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0.3f, 0, 0);
    }
}
