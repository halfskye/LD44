﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postman : PursuerSummon {
    public void Attack()
    {
        Enemy target = GetTarget();
        if (!target || !target.gameObject.activeSelf) return;
        if ((target.transform.position - this.transform.position).sqrMagnitude < 1f)
        {
            target.Damage(2);
            KillPause();
        }
    }
}
