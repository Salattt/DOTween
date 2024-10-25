using DG.Tweening;
using UnityEngine;

public class Mover : TransformChanger
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;

    private void Start()
    {
        Transform.DOMove(Transform.position + _direction, _speed)
            .SetLoops(-1,LoopType.Incremental)
            .SetEase(Ease.Linear)
            .SetSpeedBased(true);
    }
}
