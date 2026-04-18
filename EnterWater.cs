using UnityEngine;

public class EnterWater : MonoBehaviour
{
    public AudioSource windAudio;     // wind looping sound
    public AudioSource splashAudio;   // splash sound

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // turn off wind
            if (windAudio != null)
                windAudio.Stop();

            // play splash
            if (splashAudio != null)
                splashAudio.Play();
        }
    }
}