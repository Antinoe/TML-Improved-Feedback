//using ExampleMod.Common.Configs.CustomDataTypes;
//using ExampleMod.Content.Prefixes;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace ImprovedFeedback.Common
{
	[BackgroundColor(163, 44, 29)]
	public class FootstepConfig : ModConfig
	{
		public static FootstepConfig Instance;
		public override ConfigScope Mode => ConfigScope.ClientSide;

		[Header("Footsteps")]
		//[Label("$Some.Key")]
		[Label("[i:Megaphone] Footsteps Toggle")]
		[Tooltip("Determines whether or not Footstep sounds play.")]
		[DefaultValue(true)]
		//[ReloadRequired]
		public bool FootstepsToggle;
		//
		[Label("[i:Hay] Leg Frame 1")]
		[Range(1, 18)]
		[Increment(1)]
		[Slider]
		[DefaultValue(9)]
		public int LegFrame1;
		//
		[Label("[i:Hay] Leg Frame 2")]
		[Range(1, 18)]
		[Increment(1)]
		[Slider]
		[DefaultValue(16)]
		public int LegFrame2;

		[Header("FootstepDefinitions")]
		[Label("Presence Footsteps")]
		public List<ItemDefinition> itemPresenceFootsteps = new List<ItemDefinition>{
			new ItemDefinition(ItemID.HermesBoots)
		};
		[Label("Half-Life 2")]
		public List<ItemDefinition> itemHalfLife2 = new List<ItemDefinition>{
		};
		[Label("Halo 5")]
		public List<ItemDefinition> itemHalo5 = new List<ItemDefinition>{
		};
		[Label("Cloth")]
		public List<ItemDefinition> itemCloth = new List<ItemDefinition>{
			new ItemDefinition(ItemID.WoodBreastplate)
		};
		[Label("Slime")]
		public List<ItemDefinition> itemSlime = new List<ItemDefinition>{
		};
		[Label("Chainmail")]
		public List<ItemDefinition> itemChainmail = new List<ItemDefinition>{
			new ItemDefinition(ItemID.IronChainmail),
			new ItemDefinition(ItemID.GoldChainmail)
		};
		[Label("Plate")]
		public List<ItemDefinition> itemPlate = new List<ItemDefinition>{
			new ItemDefinition(ItemID.IronChainmail),
			new ItemDefinition(ItemID.GoldChainmail)
		};
		[Label("Plate Foot")]
		public List<ItemDefinition> itemPlateFoot = new List<ItemDefinition>{
			new ItemDefinition(ItemID.IronGreaves),
			new ItemDefinition(ItemID.GoldGreaves)
		};
		[Label("Crystal")]
		public List<ItemDefinition> itemCrystal = new List<ItemDefinition>{
		};
		[Label("Crystal Foot")]
		public List<ItemDefinition> itemCrystalFoot = new List<ItemDefinition>{
		};
	}
}
