using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/TeamData", order = 1)]
public class TeamData : ScriptableObject
{
    public Color teamColor;
    public Sprite logo;
}
