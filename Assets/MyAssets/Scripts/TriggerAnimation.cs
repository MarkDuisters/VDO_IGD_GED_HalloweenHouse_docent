using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] Animator anim;
    void OnMouseDown()
    {
        anim.SetTrigger("_playAnimation");
    }
}
