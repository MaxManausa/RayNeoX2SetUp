using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTargetHit : MonoBehaviour
{
    [SerializeField] public Material hitMaterial;
    [SerializeField] private TargetController _targetController;
    //[SerializeField] private Scoreboard _scoreboard;

    [SerializeField] public Material originalMaterial;
    public Renderer renderer;

    
    [SerializeField] private GameObject winScreen;
    
    [SerializeField] private AudioSource arrowAudioSource;
    [SerializeField] private AudioClip arrowHitSound;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = originalMaterial;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            renderer.material = hitMaterial;
            if (_targetController.enabled == true)
            {
                //_scoreboard.score += 1;
                //PlaySound(arrowHitSound);
            }
            /*
            if (_scoreboard.score > 9)
            
            {
                winScreen.SetActive(true);
                Debug.Log("It happened!");
            }
            */
            _targetController.enabled = false;
            //Debug.Log(_scoreboard.score);
            Invoke("TargetBackOn",6f);
        }
    }

    void TargetBackOn()
    {
        //turns the target back on
        renderer.material = originalMaterial;
        _targetController.enabled = true;
    }

    /*
    private void PlaySound(AudioClip newSound)
    {
        newSound = arrowHitSound;
        arrowAudioSource.Play();
    }
    */
}

