using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        _transform.DORotate(new Vector3(0,0,180),_duration/2).SetLoops(-1,LoopType.Incremental).SetEase(Ease.Linear);
    }
}
