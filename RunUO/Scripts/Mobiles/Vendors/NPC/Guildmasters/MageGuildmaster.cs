using System;
using System.Collections.Generic;
using Server;

namespace Server.Mobiles
{
	public class MageGuildmaster : BaseGuildmaster
	{
		public override NpcGuild NpcGuild{ get{ return NpcGuild.MagesGuild; } }

		[Constructable]
		public MageGuildmaster() : base( "mage" )
		{
			SetSkill( SkillName.EvalInt, 85.0, 100.0 );
			SetSkill( SkillName.Inscribe, 65.0, 88.0 );
			SetSkill( SkillName.MagicResist, 64.0, 100.0 );
			SetSkill( SkillName.Magery, 90.0, 100.0 );
			SetSkill( SkillName.Wrestling, 60.0, 83.0 );
			SetSkill( SkillName.Meditation, 85.0, 100.0 );
			SetSkill( SkillName.Macing, 36.0, 68.0 );
		}

		public override Item ShoeType
		{
			get{ return new Server.Items.Sandals(); }
		}

		public override void InitOutfit()
		{
			base.InitOutfit();

			AddItem( new Server.Items.Robe( Utility.RandomBlueHue() ) );
            PackScroll(4, 8);
            PackScroll(4, 8);
		}

		public MageGuildmaster( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}