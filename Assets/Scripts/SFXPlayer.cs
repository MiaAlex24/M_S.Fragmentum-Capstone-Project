using UnityEngine;


public class SFXPlayer : MonoBehaviour
{
    // Start is called before the first frame update
 
  
    public AudioSource sfxSource;
    public AudioClip[] sfxclip;
    public AudioSource[] audioSource;
    void Start()
    {

    }

    public void PlayVoiceline(int audio)
    {
        audioSource[audio].Play();
    }

    public void PlaySFX(int sfx)
    {
        sfxSource.PlayOneShot(sfxclip[sfx]);
 
    }
}
