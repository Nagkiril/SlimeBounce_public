using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlimeBounce.Slime.Status.Effectables
{
    public interface IPickupEffectable
    {
        public bool VerifyPickupBlock();
    }
}