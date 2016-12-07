namespace _13备忘录模式
{
    class RoleStateMemento
    {
        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality { get; private set; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense { get; set; }

        public RoleStateMemento(Role role)
        {
            Vitality = role.Vitality;
            Attack = role.Attack;
            Defense = role.Defense;
        }
    }
}