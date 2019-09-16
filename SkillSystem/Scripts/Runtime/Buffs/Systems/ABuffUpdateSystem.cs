//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月14日-19:30
//CabinIcarus.SkillSystem.Runtime

using Cabin_Icarus.SkillSystem.Scripts.Runtime.Buffs.Entitys;
using CabinIcarus.SkillSystem.Runtime.Buffs.Components;
using CabinIcarus.SkillSystem.Runtime.Buffs.Systems.Interfaces;
using CabinIcarus.SkillSystem.Scripts.Runtime.Buffs;

namespace Cabin_Icarus.SkillSystem.Scripts.Runtime.Buffs.Systems
{
    public abstract class ABuffUpdateSystem : IBuffUpdateSystem
    {
        protected readonly IBuffManager BuffManager;

        protected ABuffUpdateSystem(IBuffManager buffManager)
        {
            BuffManager = buffManager;
        }
        
        public abstract bool Filter(IEntity entity);
        public abstract void Execute(IEntity entity);
    }
}