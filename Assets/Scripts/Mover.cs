using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;

    private Transform _transform;
    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        _transform.DOMove(_transform.position + _direction, _speed).SetLoops(-1,LoopType.Incremental).SetEase(Ease.Linear).SetSpeedBased(true);
    }
}
