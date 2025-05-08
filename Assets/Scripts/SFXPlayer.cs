using UnityEngine;


public class SFXPlayer : MonoBehaviour
{
    // Start is called before the first frame update
 
    public AudioSource audioSource;
    public AudioSource sfxSource;
    public AudioClip[] sfxclip;
    public AudioClip[] voicelines;
    void Start()
    {

    }

    public void PlayVoiceline(int lineNum)
    {
        audioSource.PlayOneShot(voicelines[lineNum]);
    }

    public void PlaySFX(int sfx)
    {
        sfxSource.PlayOneShot(sfxclip[sfx]);
 
    }
}
