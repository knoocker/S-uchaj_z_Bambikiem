using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MusicCollection", menuName = "MusicCollection", order = 1)]
public class MusicCollection : ScriptableObject
{
    public AudioClip[] music;

}
