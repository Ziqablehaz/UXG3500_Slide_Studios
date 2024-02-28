using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Transform targetPos;

    private void Update()
    {
        Vector3 delta = new Vector3(targetPos.position.x - transform.position.x, 0.0f, targetPos.position.z - transform.position.z);
        Quaternion rotation = Quaternion.LookRotation(delta);
        transform.rotation = rotation;
    }
}