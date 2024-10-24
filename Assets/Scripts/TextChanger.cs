using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _loopTime;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("я добавочный текст",_loopTime / 3).SetRelative(true));
        sequence.Append(_text.DOText("я текст - замена", _loopTime / 3));
        sequence.Append(_text.DOText("я хакнутый текст", _loopTime / 3, false, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Restart);
    }
}
