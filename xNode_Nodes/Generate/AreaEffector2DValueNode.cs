using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/Physics2DModule/AreaEffector2D Value")]
    public partial class AreaEffector2DValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.AreaEffector2D _value;

        public override Type ValueType { get; } = typeof(UnityEngine.AreaEffector2D);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}