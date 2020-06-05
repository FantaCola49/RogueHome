using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private AudioSource _audio;
    private bool _isIN; // _isIN ~ Rogue entered the house?

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Rogue>(out Rogue rogue))
        {
            if (!_isIN)
            {
                _isIN = true;
                _audio.Play();
            }
            else
                _isIN = false;

            Debug.Log("The Rogue went through the door!!!");
        }
    }

    // Volume change depends on deltatime and _isIN bool trigger
    private void Update()
    {
        if (_isIN)
        {
            _audio.volume += Time.deltaTime/10;
        }
        else
        {
            _audio.volume -= Time.deltaTime / 10;
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
