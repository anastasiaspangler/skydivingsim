using UnityEngine;

public class PlaneExitTrigger : MonoBehaviour
{
    [SerializeField] private Transform ovrRigRoot;
    [SerializeField] private Transform fallingController;
    [SerializeField] private AudioSource windAudio;

    private bool triggered;

    private void OnTriggerExit(Collider other)
    {
        if (triggered) return;

        // Easiest check: did the rig root itself leave?
        if (other.transform == ovrRigRoot || other.transform.IsChildOf(ovrRigRoot))
        {
            triggered = true;

            // Move rig from plane to falling controller
            ovrRigRoot.SetParent(fallingController, true);

            // Start wind
            if (windAudio != null && !windAudio.isPlaying)
                windAudio.Play();
        }
    }
}