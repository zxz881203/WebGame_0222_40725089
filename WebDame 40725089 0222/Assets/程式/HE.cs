using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class HE : HS
    {
        [SerializeField, Header("�ĤH���")]
        private DE data;
        private void Start()
        {
            hp = data.hp;
        }
    }
}