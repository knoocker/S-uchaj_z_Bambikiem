using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    private SoundPlayer soundPlayer;
    public float waitForEntrySound = 1.0f;


    void Start()
    {
        soundPlayer = GetComponentInChildren<SoundPlayer>();
        StartCoroutine(PlayEntrySound());

    }

    void Update()
    {
        
    }

    public void PlaySound(Button otherObject)
    {
        if(otherObject.tag == "SoundButton")
        {
            soundPlayer.PlaySound((int)MenuSceneSoundsEnum.WybierzRodzajCwiczen);
        }
    }

    private void PlaySound(MenuSceneSoundsEnum whatSound)
    {
        soundPlayer.PlaySound((int)whatSound);
    }
    
    IEnumerator PlayEntrySound()
    {
        yield return new WaitForSeconds(waitForEntrySound);
        PlaySound(MenuSceneSoundsEnum.WybierzRodzajCwiczen);
    }
}
