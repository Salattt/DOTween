using UnityEngine;

public class TransformChanger : MonoBehaviour
{
    protected Transform Transform;

    private void Awake()
    {
        Transform = transform;
    }
}
