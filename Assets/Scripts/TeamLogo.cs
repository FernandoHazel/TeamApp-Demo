using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TeamLogo : MonoBehaviour
{
    [SerializeField] TeamData teamData;
    private void Awake() 
    {
        Image image = GetComponent<Image>();
        image.sprite = teamData.logo;
    }
}
