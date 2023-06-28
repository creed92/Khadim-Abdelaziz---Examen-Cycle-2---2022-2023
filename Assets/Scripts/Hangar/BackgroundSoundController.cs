using UnityEngine;

public class BackgroundSoundController : MonoBehaviour
{
    public AudioSource backgroundSound;
    public GameObject codecPanel;

    private float normalVolume;

    private void Start()
    {
        normalVolume = backgroundSound.volume;
        backgroundSound.Play();
        backgroundSound.loop = true;
    }

    private void Update()
    {
        if (codecPanel.activeSelf)
        {
            // Lower the volume when the codec panel is active
            backgroundSound.volume = normalVolume * 0.5f;
        }
        else
        {
            // Restore the normal volume when the codec panel is not active
            backgroundSound.volume = normalVolume;
        }
    }
}

