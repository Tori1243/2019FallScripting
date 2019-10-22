using UnityEngine;

[CreateAssetMenu]

public class AnimController : ScriptableObject
{
    public void AnimCall(Animator Controller)
    {
        animator.SetTrigger(this.name);
    }
}
