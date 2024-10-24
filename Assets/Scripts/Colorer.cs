using DG.Tweening;
using UnityEngine;

[RequireComponent (typeof(MeshRenderer))]
public class Colorer : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _loopTime;

    private Material _material;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    private void Start()
    {
        _material.DOColor(_color, _loopTime / 2).SetLoops(-1, LoopType.Yoyo);
    }
}