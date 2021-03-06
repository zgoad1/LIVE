﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkHitbox : MonoBehaviour {

	/** Any attack hitbox.
	 * 
	 * SET UPON START:
	 * - isAlly
	 * - me
	 * - hbIndex
	 */

	protected BattleEntity me;
	protected int hbIndex;
	protected bool isAlly;

	protected virtual void Reset() {
		//me = FindObjectOfType<BattlePlayer>();
	}

	protected virtual bool IsAttacking() {
		return me.attacking[hbIndex];
	}

	protected virtual void Hit(Rigidbody hit) {
		Debug.Log("Attempting to damage someone for " + me.atkDamage[hbIndex]);
	}
}
