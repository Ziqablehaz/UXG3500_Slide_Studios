using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera camera;

    private void LateUpdate()
    {
        transform.rotation = camera.transform.rotation;
    }
}