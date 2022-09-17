using UnityEngine;
using Random = UnityEngine.Random;

public class AmazingTextAnimationController : MonoBehaviour
{
    [SerializeField] private Animator[] allAnimators;
    [SerializeField] private float minimumDelay = 3;
    private bool _canPlay = true;

    public static AmazingTextAnimationController Instance;

    private void Awake() => Instance = this;

    private int _animationState = Animator.StringToHash("AmazingTextAnimation");

    void PlayAnimation(int index)
    {
        if (index > allAnimators.Length - 1) return;
        if(_canPlay == false) return;
        _canPlay = false;
        allAnimators[index].CrossFade(_animationState, 0.1f);
        Invoke(nameof(DoSetCanPlayToTrue),minimumDelay);
    }

    void DoSetCanPlayToTrue() => _canPlay = true;

    [ContextMenu("Play random")]
    public void PlayOneAnimationRandomly()
    {
        PlayAnimation(Random.Range(0, allAnimators.Length));
    }
}