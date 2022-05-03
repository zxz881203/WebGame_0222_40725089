using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class HE : HS
    {
        [SerializeField, Header("¼Ä¤H¸ê®Æ")]
        private DE data;
        private void Start()
        {
            hp = data.hp;
        }
    }
}