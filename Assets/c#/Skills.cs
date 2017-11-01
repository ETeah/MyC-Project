using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Skills : MonoBehaviour {

    public List<Skill> skills;

    void Awake()
    {
        skills[0].currentCooldown = skills[0].cooldown;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
             if (skills[0].currentCooldown >= skills[0].cooldown)
            {
                //skill
                skills[0].currentCooldown = 0;
            }
        }

    }

    void Update ()
    {
		foreach(Skill s in skills)
        {
            s.currentCooldown += Time.deltaTime;
            s.skillIcon.fillAmount = s.currentCooldown / s.cooldown;
        }
	}
}

[System.Serializable]
public class Skill
{
    public float cooldown;
    public Image skillIcon;
    [HideInInspector]
    public float currentCooldown;
}
