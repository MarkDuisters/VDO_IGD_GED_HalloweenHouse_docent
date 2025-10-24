using System.Collections.Generic;
using UnityEngine;

public class ToggleLights : MonoBehaviour
{
    [SerializeField] Light[] getLights;
    [SerializeField] AudioClip[] lightOn;
    [SerializeField] AudioClip lightOff;
    [SerializeField] AudioSource audioSource;
    //  [SerializeField] List<Light> getLights2;

    void Start()
    {
        if (audioSource == null && GetComponent<AudioSource>() != null)
        {
            audioSource = GetComponent<AudioSource>();
            //GetComponent zonder een referentie naar een ander GameObject
            //verwijst altijd naar het GameObject waar dit SCRIPT op zit.
        }
    }

    void OnMouseDown()
    {
        foreach (Light light in getLights)
        {
            /*   if (light.enabled)
                   light.enabled = false;
               else
                   light.enabled = true;*/
            light.enabled = !light.enabled;//met ! kunnen we de omgekeerde waarde van een boolean krijgen.
            //We kunnen dus de bestaande waarde met de inverse van zichzelf overschrijven.
            if (light.enabled)
            {
                if (lightOn.Length == 0) continue;
                int randomIndex = Random.Range(0, lightOn.Length);
                if (lightOn[randomIndex] == null) continue;
                audioSource.PlayOneShot(lightOn[randomIndex]);
            }
            else
            {
                if (lightOff == null) continue;
                audioSource.PlayOneShot(lightOff);
            }



        }
    }
}
