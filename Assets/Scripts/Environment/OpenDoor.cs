using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private AudioSource _alert;
    private int _volumeChangeStep = 5;
    private bool _doorOpened;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Rogue>(out Rogue rogue))
        {
            if (_doorOpened)
            {
                _doorOpened = false;
            }
            else
            {
                _doorOpened = true;
                _alert.Play();
            }
            Debug.Log("The Rogue went through the door!!!");
        }
    }

    private void Update()
    {
        if (_doorOpened & _alert.volume <= 1)
        {
            _alert.volume += Time.deltaTime / _volumeChangeStep;
        }
        else
        {
            _alert.volume -= Time.deltaTime / _volumeChangeStep;
        }

        if (_alert.volume == 0)
            _alert.Stop();
    }

    private void Start()
    {
        _alert = GetComponent<AudioSource>();
        _alert.volume = 0.01f ;
    }
}
