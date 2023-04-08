using System.Collections;
using UnityEngine;

public class DisableAudioSourceWhenNotPlaying : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource = null;

    private bool _canCheck = false;

    private void OnEnable()
    {
        _canCheck = false;
        StartCoroutine(EnableChecking());
    }

    // Update is called once per frame
    void Update()
    {
        if (!_canCheck)
            return;

        CheckIfAudioSourceIsStillPlaying();
    }

    private void CheckIfAudioSourceIsStillPlaying()
    {
        if (!_audioSource.isPlaying)
        {
            gameObject.SetActive(false);
            _audioSource.spatialBlend = 0;
        }
    }

    private IEnumerator EnableChecking()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        _canCheck = true;
    }
}
