using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingMonsterHit : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;
    [SerializeField] private ParticleSystem particleSystem;

    [SerializeField] private Scoreboard scoreboard;
    [SerializeField] private GameObject winScreen;
    
    [SerializeField] private AudioSource wingsAudioSource;
    [SerializeField] private AudioClip wingflappingSound;
    
    [SerializeField] private AudioSource explosionAudioSource;
    [SerializeField] private AudioSource arrowWhooshManager;
    [SerializeField] private AudioClip explosionSound;
    [SerializeField] private AudioClip deathGrunt;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            if (skinnedMeshRenderer.enabled == true)
            {
                PlayDeathGrunt(deathGrunt);
                scoreboard.score += 1;
                scoreboard.UpdateScore();
                PlayExplosionSound(explosionSound);
                PausewingflappingSound(wingflappingSound);
            }
            skinnedMeshRenderer.enabled = false;
            particleSystem.Play();
            
            if (scoreboard.score > scoreboard.onelessthanwinningScore)
            {
                winScreen.SetActive(true);
                Debug.Log("It happened!");
            }
            //Debug.Log(_scoreboard.score);
            Invoke("TargetBackOn",6f);
        }
    }

    public void MonsterHit()
    {
        PlayDeathGrunt(deathGrunt);
        PlayExplosionSound(explosionSound);
        PausewingflappingSound(wingflappingSound);
        skinnedMeshRenderer.enabled = false;
        particleSystem.Play();
        
        Invoke("TargetBackOn",6f);
    }

    void TargetBackOn()
    {
        //turns the target back on
        skinnedMeshRenderer.enabled = true;
        PlaywingflappingSound(wingflappingSound);
    }

    public void PlayDeathGrunt(AudioClip newSound)
    {
        newSound = deathGrunt;
        arrowWhooshManager.Play();
    }
    
    public void PlayExplosionSound(AudioClip newSound)
    {
        newSound = explosionSound;
        explosionAudioSource.Play();
    }

    public void PlaywingflappingSound(AudioClip newSound)
    {
        newSound = wingflappingSound;
        wingsAudioSource.Play();
    }
    
    public void PausewingflappingSound(AudioClip newSound)
    {
        newSound = wingflappingSound;
        wingsAudioSource.Stop();
    }
    
}
