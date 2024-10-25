using DG.Tweening;
using UnityEngine;

public class Rotator : TransformChanger
{
    [SerializeField] private float _animationTime;
    [SerializeField] private Vector3 _rotationPerAnimation;

    private void Start()
    {
        Transform.DORotate(_rotationPerAnimation,_animationTime)
            .SetLoops(-1,LoopType.Incremental)
            .SetEase(Ease.Linear);
    }
}
