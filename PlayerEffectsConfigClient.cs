using System.Collections.Generic;
using System.ComponentModel;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
//using static MetroidMod.MetroidMod;
//using static MetroidMod.Content.Items.Armors;

namespace PlayerEffects
{
    [Label("Client Config")]
    public class PlayerEffectsConfigClient : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ClientSide;
		
        public static PlayerEffectsConfigClient Instance;
		
	[Header("[i:Nazar] Visual")]
		
        [Label("[i:StoneBlock] Enable Screenshake")]
        [Tooltip("If false, the effects of this mod will not produce Screenshake.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableScreenshake {get; set;}
		
	[Header("[i:Megaphone] Audio")]
		
        [Label("[i:Megaphone] Enable Sounds")]
        [Tooltip("If false, the sounds of this mod will not be played.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableSounds {get; set;}
		
        [Label("[i:Megaphone] Vanilla Sounds")]
        [Tooltip("If false, this mod's custom sounds will be played instead of Vanilla variations.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool enableVanillaSounds {get; set;}
		
		[Label("[i:HermesBoots] Rubber Flip-Flop Step Whitelist")]
		public List<ItemDefinition> itemStepRubberFlipflopWhitelist = new List<ItemDefinition>
			{
			};
		
		[Label("[i:HermesBoots] Light Leather Boot Step Whitelist")]
		public List<ItemDefinition> itemStepLeatherBootLightWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.HermesBoots),
				new ItemDefinition(ItemID.WoodGreaves),
				new ItemDefinition(ItemID.CopperGreaves),
				new ItemDefinition(ItemID.TinGreaves),
				new ItemDefinition(ItemID.IronGreaves),
				new ItemDefinition(ItemID.LeadGreaves),
				new ItemDefinition(ItemID.GoldGreaves),
				new ItemDefinition(ItemID.PlatinumGreaves)
			};
		
		[Label("[i:HermesBoots] Medium Leather Boot Step Whitelist")]
		public List<ItemDefinition> itemStepLeatherBootMediumWhitelist = new List<ItemDefinition>
			{
			};
		
		[Label("[i:HermesBoots] Heavy Leather Boot Step Whitelist")]
		public List<ItemDefinition> itemStepLeatherBootHeavyWhitelist = new List<ItemDefinition>
			{
				//new ItemDefinition(ModContent.ItemType<PowerSuitGreaves>())
			};
		
		[Label("[i:Cobweb] Light Cloth Rustle Whitelist")]
		public List<ItemDefinition> itemRustleClothLightWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.WoodBreastplate),
				new ItemDefinition(ItemID.WoodGreaves)
			};
		
		[Label("[i:Silk] Medium Cloth Rustle Whitelist")]
		public List<ItemDefinition> itemRustleClothMediumWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.CopperChainmail),
				new ItemDefinition(ItemID.CopperGreaves)
			};
		
		[Label("[i:Leather] Heavy Cloth Rustle Whitelist")]
		public List<ItemDefinition> itemRustleClothHeavyWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.IronChainmail),
				new ItemDefinition(ItemID.IronGreaves)
			};
		
		[Label("[i:SWATHelmet] Light Rattle Rustle Whitelist")]
		public List<ItemDefinition> itemRustleRattleLightWhitelist = new List<ItemDefinition>
			{
			};
		
		[Label("[i:SWATHelmet] Heavy Rattle Rustle Whitelist")]
		public List<ItemDefinition> itemRustleRattleHeavyWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.BeetleShell),
				new ItemDefinition(ItemID.BeetleLeggings)
			};
		
		[Label("[i:SWATHelmet] Heavy Aramid Rustle Whitelist")]
		public List<ItemDefinition> itemRustleAramidHeavyWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.BeetleShell),
				new ItemDefinition(ItemID.BeetleLeggings)
			};
		
        /*[Label("[i:HermesBoots] Left Foot Step Frame")]
        [Tooltip("[Default: 10]")]
        [Slider]
        [DefaultValue(10)]
        [Range(0, 19)]
        [Increment(1)]
        public int footStepLeft {get; set;}*/
		
    }
}