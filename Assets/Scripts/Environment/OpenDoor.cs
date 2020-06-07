using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private AudioSource _audio;
    private bool _RogueEntered;
    private int _VolumeRate = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Rogue>(out Rogue rogue))
        {
            if (!_RogueEntered)
            {
                _RogueEntered = true;
                _audio.Play();
            }
            else
            {
                _RogueEntered = false;
            }

            Debug.Log("The Rogue went through the door!!!");
        }
    }

    private void Update()
    {
        if (_RogueEntered)
        {
            _audio.volume += (Time.deltaTime / _VolumeRate);
        }
        else
        {
            _audio.volume -= (Time.deltaTime / _VolumeRate);
        }
        if (_audio.volume == 0)
            _audio.Stop();
    }

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
        _audio.volume = 0.01f ;
    }
}
