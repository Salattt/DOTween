using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _loopTime;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        _transform.DOScale(_targetScale, _loopTime / 2).SetLoops(-1,LoopType.Yoyo);
    }
}
