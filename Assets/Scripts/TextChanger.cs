using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _AnimationTime;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("я добавочный текст",_AnimationTime).SetRelative(true));
        sequence.Append(_text.DOText("я текст - замена", _AnimationTime));
        sequence.Append(_text.DOText("я хакнутый текст", _AnimationTime, false, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Restart);
    }
}
