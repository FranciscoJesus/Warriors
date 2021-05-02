using Ardalis.SmartEnum;

namespace Exercise.Warriors.Players
{
    public abstract class WarriorType : SmartEnum<WarriorType>
    {
        public static readonly WarriorType Dwarf = new DwarfType();
        public static readonly WarriorType Boxer = new BoxerType();
        public static readonly WarriorType Elf = new ElfType();
        public static readonly WarriorType Kangaroo = new KangarooType();

        private WarriorType(string name, int value) : base(name,value)
        {
        }

        public abstract Warrior CreatePlayer();

        private sealed class DwarfType: WarriorType
        {
            public DwarfType() : base("Dwarf", 1) 
            {
            }

            public override Warrior CreatePlayer()
            {
                return new Dwarf();
            }
        }

        private sealed class BoxerType : WarriorType
        {
            public BoxerType() : base("Boxer", 2)
            {
            }

            public override Warrior CreatePlayer()
            {
                return new Boxer();
            }
        }

        private sealed class ElfType : WarriorType
        {
            public ElfType() : base("Elf", 3)
            {
            }

            public override Warrior CreatePlayer()
            {
                return new Elf();
            }
        }

        private sealed class KangarooType : WarriorType
        {
            public KangarooType() : base("Kangaroo", 4)
            {
            }

            public override Warrior CreatePlayer()
            {
                return new Kangaroo();
            }
        }
    }
}
