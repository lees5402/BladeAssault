using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimationHash
{
    public readonly static int Idle = Animator.StringToHash("Idle");
    public readonly static int Run = Animator.StringToHash("Run");
    public readonly static int Jump = Animator.StringToHash("Jump");
}
