using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignAbilityToBar : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private GameObject button01;
    private GameObject button02;
    private GameObject button03;

    #region abilitySlot01
    public void AssignAbilitySlot01(string buttonName)
    {
        button01 = GameObject.FindGameObjectWithTag("SkillButton01");
        button02 = GameObject.FindGameObjectWithTag("SkillButton02");
        button03 = GameObject.FindGameObjectWithTag("SkillButton03");

        if (buttonName == "AscendingShot")
        {        
            if(button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.AscendingShot_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
           
        }
        if (buttonName == "AscendingShot_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.AscendingShot_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        if (buttonName == "LaceratingTyphoon")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.LaceratingTyphoon_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        if (buttonName == "LaceratingTyphoon_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.LaceratingTyphoon_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingShot")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingShot_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingShot_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingShot_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "UncontrolledSpeed")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.UncontrolledSpeed_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "UncontrolledSpeed_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.UncontrolledSpeed_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingFist")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingFist_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingFist_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingFist_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HeavensPiercer")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HeavenPiercer_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HeavensPiercer_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HeavenPiercer_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "WrathsDestruction")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.WraithsDestruction_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "WrathsDestruction_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.WraithsDestruction_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HowlingScythe")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HowlingScythe_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HowlingScythe_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HowlingScythe_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "VortexDischarge")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.VortexDischarge_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "VortexDischarge_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.VortexDischarge_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SearingIgnition")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SearingIgnition_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SearingIgnition_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SearingIgnition_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PermaFrost")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.Permafrost_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PermaFrost_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_02
                   && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.Permafrost_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SpiralingTempest")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_01)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SpiralingTempest_01;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SpiralingTempest_Tier02")
        {
            if (button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_02)
            {
                button01.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SpiralingTempest_02;
                button01.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
    }
    #endregion

    #region abilitySlot02
    public void AssignAbilitySlot02(string buttonName)
    {
        button01 = GameObject.FindGameObjectWithTag("SkillButton01");
        button02 = GameObject.FindGameObjectWithTag("SkillButton02");
        button03 = GameObject.FindGameObjectWithTag("SkillButton03");

        if (buttonName == "AscendingShot")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.AscendingShot_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        if (buttonName == "AscendingShot_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.AscendingShot_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        if (buttonName == "LaceratingTyphoon")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.LaceratingTyphoon_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        if (buttonName == "LaceratingTyphoon_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.LaceratingTyphoon_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingShot")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingShot_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingShot_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingShot_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "UncontrolledSpeed")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.UncontrolledSpeed_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "UncontrolledSpeed_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.UncontrolledSpeed_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingFist")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingFist_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingFist_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingFist_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HeavensPiercer")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HeavenPiercer_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HeavensPiercer_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HeavenPiercer_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "WrathsDestruction")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.WraithsDestruction_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "WrathsDestruction_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.WraithsDestruction_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HowlingScythe")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HowlingScythe_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HowlingScythe_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HowlingScythe_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "VortexDischarge")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.VortexDischarge_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "VortexDischarge_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.VortexDischarge_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SearingIgnition")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SearingIgnition_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SearingIgnition_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SearingIgnition_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PermaFrost")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.Permafrost_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PermaFrost_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.Permafrost_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SpiralingTempest")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_01
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_01)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SpiralingTempest_01;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SpiralingTempest_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_02
                && button03.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_02)
            {
                button02.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SpiralingTempest_02;
                button02.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
    }
    #endregion

    #region abilitySlot03
    public void AssignAbilitySlot03(string buttonName)
    {
        button01 = GameObject.FindGameObjectWithTag("SkillButton01");
        button02 = GameObject.FindGameObjectWithTag("SkillButton02");
        button03 = GameObject.FindGameObjectWithTag("SkillButton03");

        if (buttonName == "AscendingShot")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.AscendingShot_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        if (buttonName == "AscendingShot_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.AscendingShot_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.AscendingShot_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        if (buttonName == "LaceratingTyphoon")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_01  
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.LaceratingTyphoon_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        if (buttonName == "LaceratingTyphoon_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.LaceratingTyphoon_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.LaceratingTyphoon_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingShot")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingShot_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingShot_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingShot_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingShot_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "UncontrolledSpeed")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.UncontrolledSpeed_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "UncontrolledSpeed_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.UncontrolledSpeed_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.UncontrolledSpeed_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingFist")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingFist_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PiercingFist_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.PiercingFist_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.PiercingFist_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HeavensPiercer")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HeavenPiercer_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HeavensPiercer_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HeavenPiercer_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HeavenPiercer_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "WrathsDestruction")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.WraithsDestruction_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "WrathsDestruction_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.WraithsDestruction_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.WraithsDestruction_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HowlingScythe")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HowlingScythe_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "HowlingScythe_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.HowlingScythe_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.HowlingScythe_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "VortexDischarge")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.VortexDischarge_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "VortexDischarge_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.VortexDischarge_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.VortexDischarge_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SearingIgnition")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SearingIgnition_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SearingIgnition_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SearingIgnition_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SearingIgnition_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "PermaFrost")
        {
                if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_01)
                {
                    button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.Permafrost_01;
                    button03.GetComponent<PlayerMovement>().AssignButtonSprite();
                }
        }
        else if (buttonName == "PermaFrost_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.Permafrost_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.Permafrost_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SpiralingTempest")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_01
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_01)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SpiralingTempest_01;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
        else if (buttonName == "SpiralingTempest_Tier02")
        {
            if (button01.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_02
                && button02.GetComponent<PlayerMovement>().buttonType != PlayerMovement.type.SpiralingTempest_02)
            {
                button03.GetComponent<PlayerMovement>().buttonType = PlayerMovement.type.SpiralingTempest_02;
                button03.GetComponent<PlayerMovement>().AssignButtonSprite();
            }
        }
    }
    #endregion
}
