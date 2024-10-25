using DG.Tweening;
using UnityEngine;

public class Scaler : TransformChanger
{ 
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _halfLoopTime;

    private void Start()
    {
        Transform.DOScale(_targetScale, _halfLoopTime)
            .SetLoops(-1,LoopType.Yoyo);
    }
}
