using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Sources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clips")]
    public AudioClip backgroundMusic;
    [SerializeField] private List<WeaponSFXClipPair> weaponSFXClipPairs;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }

    public void PlayWeaponSFX(WeaponSFX weaponSFX)
    {
        SFXSource.PlayOneShot(weaponSFXClipPairs.Find(x => x.weaponSFX == weaponSFX).clip);
    }

}

[System.Serializable]
public class WeaponSFXClipPair
{
    public WeaponSFX weaponSFX;
    public AudioClip clip;
}

public enum WeaponSFX{
    Whip,
    Knife,
    Axe,
    Magic,
}
