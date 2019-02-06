using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "sounds", menuName = "SoundsCollection", order = 1)]
public class SoundCollection : ScriptableObject
{
        public AudioClip[] sounds;
}
