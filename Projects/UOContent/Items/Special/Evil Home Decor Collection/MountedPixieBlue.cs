namespace Server.Items
{
    [Flippable(0x2A75, 0x2A76)]
    public class MountedPixieBlueComponent : AddonComponent
    {
        public MountedPixieBlueComponent() : base(0x2A75)
        {
        }

        public MountedPixieBlueComponent(Serial serial) : base(serial)
        {
        }

        public override int LabelNumber => 1074482; // Mounted pixie

        public override void OnDoubleClick(Mobile from)
        {
            if (Utility.InRange(Location, from.Location, 2))
            {
                Effects.PlaySound(Location, Map, Utility.RandomMinMax(0x55C, 0x55E));
            }
            else
            {
                from.LocalOverheadMessage(MessageType.Regular, 0x3B2, 1019045); // I can't reach that.
            }
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadEncodedInt();
        }
    }

    public class MountedPixieBlueAddon : BaseAddon
    {
        public MountedPixieBlueAddon()
        {
            AddComponent(new MountedPixieBlueComponent(), 0, 0, 0);
        }

        public MountedPixieBlueAddon(Serial serial) : base(serial)
        {
        }

        public override BaseAddonDeed Deed => new MountedPixieBlueDeed();

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadEncodedInt();
        }
    }

    public class MountedPixieBlueDeed : BaseAddonDeed
    {
        [Constructible]
        public MountedPixieBlueDeed() => LootType = LootType.Blessed;

        public MountedPixieBlueDeed(Serial serial) : base(serial)
        {
        }

        public override BaseAddon Addon => new MountedPixieBlueAddon();
        public override int LabelNumber => 1074482; // Mounted pixie

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadEncodedInt();
        }
    }
}
