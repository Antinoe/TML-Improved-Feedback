using System.Collections.Generic;
using System.ComponentModel;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
//using static MetroidMod.MetroidMod;
//using static MetroidMod.Content.Items.Armors;

namespace ImprovedFeedback
{
    [Label("Basic")]
    public class ImprovedFeedbackConfigClientBasic : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
		
        public static ImprovedFeedbackConfigClientBasic Instance;

	[Header("[i:Nazar]Visual")]
		
        /*[Label("[i:StoneBlock] Enable Screenshake")]
        [Tooltip("If true, the effects of this mod will produce Screenshake.\n[Default: On]")]*/
        [DefaultValue(true)]
        public bool enableScreenshake {get; set;}
		
        /*[Label("[i:StoneBlock] Enable Falling Effect")]
        [Tooltip("If true, the screen will shake when falling great distances.\n[Default: On]")]*/
        [DefaultValue(true)]
        public bool enableFallingEffect {get; set;}
		
        /*[Label("[i:StoneBlock] Enable Landing Effect")]
        [Tooltip("If true, the screen will shake when landing.\n[Default: On]")]*/
        [DefaultValue(true)]
        public bool enableLandingEffect {get; set;}
		
        /*[Label("[i:StoneBlock] Enable Damage Effect")]
        [Tooltip("If true, the screen will shake depending on how much damage was dealt.\n[Default: On]")]*/
        [DefaultValue(true)]
        public bool enableDamageEffect {get; set;}
		
	[Header("[i:Megaphone]Audio")]
		
        /*[Label("[i:Megaphone] Enable Sounds")]
        [Tooltip("If true, the sounds of this mod will be played.\n[Default: On]")]*/
        [DefaultValue(true)]
        public bool enableSounds {get; set;}
		
        /*[Label("[i:Megaphone][i:HermesBoots] Enable Step Sounds")]
        [Tooltip("If true, a sound will be played each time a player takes a step, depending on the materials worn.\n[Default: On]")]*/
        [DefaultValue(true)]
        public bool enableStepSounds {get; set;}
		
        /*[Label("[i:Megaphone][i:LuckyHorseshoe] Enable Skid Sound")]
        [Tooltip("If true, a sound will be played each time a player comes to a stop.\n[Default: On]")]*/
        [DefaultValue(true)]
        public bool enableSkidSounds {get; set;}
		
        /*[Label("[i:Megaphone][i:CloudinaBottle] Enable Jump Sounds")]
        [Tooltip("If true, a sound will be played each time a player jumps.\n[Default: On]")]*/
        [DefaultValue(true)]
        public bool enableJumpSounds {get; set;}
		
        /*[Label("[i:Megaphone][i:LuckyHorseshoe] Enable Land Sounds")]
        [Tooltip("If true, a sound will be played each time a player lands.\n[Default: On]")]*/
        [DefaultValue(true)]
        public bool enableLandSounds {get; set;}
		
        /*[Label("[i:Bone] Enable Dynamic Damage Effects")]
        [Tooltip("If true, the Player Hurt sound will depend on certain conditions. (Attire, Damage dealt, etc.)\n[Default: On]")]*/
        [DefaultValue(true)]
        public bool enableDynamicDamageEffects {get; set;}
	}

    [Label("Developer")]
    public class ImprovedFeedbackConfigClientDeveloper : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
		
        public static ImprovedFeedbackConfigClientDeveloper Instance;
		
		/*[Label("[i:HermesBoots] GTA 5 Sandal Step Whitelist")]*/
		public List<ItemDefinition> itemStepSandalGTA5Whitelist = new List<ItemDefinition>
			{
			};
		
		/*[Label("[i:HermesBoots] GTA 5 Boot Step Whitelist")]*/
		public List<ItemDefinition> itemStepBootGTA5Whitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.HermesBoots),
				new ItemDefinition(ItemID.WoodGreaves),
				new ItemDefinition(ItemID.EbonwoodGreaves),
				new ItemDefinition(ItemID.PearlwoodGreaves),
				new ItemDefinition(ItemID.ShadewoodGreaves),
				new ItemDefinition(ItemID.BorealWoodGreaves),
				new ItemDefinition(ItemID.PalmWoodGreaves),
				new ItemDefinition(ItemID.RichMahoganyGreaves),
				new ItemDefinition(ItemID.CopperGreaves),
				new ItemDefinition(ItemID.TinGreaves),
				new ItemDefinition(ItemID.IronGreaves),
				new ItemDefinition(ItemID.LeadGreaves),
				new ItemDefinition(ItemID.SilverGreaves),
				new ItemDefinition(ItemID.TungstenGreaves),
				new ItemDefinition(ItemID.GoldGreaves),
				new ItemDefinition(ItemID.PlatinumGreaves)
			};
		
		/*[Label("[i:HermesBoots] Super Metroid Power Suit Step Whitelist")]*/
		public List<ItemDefinition> itemStepPowerSuitSuperMetroidWhitelist = new List<ItemDefinition>
			{
			};
		
		/*[Label("[i:HermesBoots] Metroid Fusion Fusion Suit Step Whitelist")]*/
		public List<ItemDefinition> itemStepFusionSuitMetroidFusionWhitelist = new List<ItemDefinition>
			{
			};
		
		/*[Label("[i:HermesBoots] DOOM 2016 Praetor Suit Step Whitelist")]*/
		public List<ItemDefinition> itemStepPraetorSuitDOOM2016Whitelist = new List<ItemDefinition>
			{
			};
		
		/*[Label("[i:HermesBoots] Halo 5 Mjolnir Armor Step Whitelist")]*/
		public List<ItemDefinition> itemStepMjolnirArmorHalo5Whitelist = new List<ItemDefinition>
			{
				//new ItemDefinition(ModContent.ItemType<PowerSuitGreaves>())
			};
		
		/*[Label("[i:Cobweb] Light Cloth Rustle Whitelist")]*/
		public List<ItemDefinition> itemRustleClothLightWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.WoodBreastplate),
				new ItemDefinition(ItemID.WoodGreaves),
				new ItemDefinition(ItemID.EbonwoodBreastplate),
				new ItemDefinition(ItemID.EbonwoodGreaves),
				new ItemDefinition(ItemID.PearlwoodBreastplate),
				new ItemDefinition(ItemID.PearlwoodGreaves),
				new ItemDefinition(ItemID.ShadewoodBreastplate),
				new ItemDefinition(ItemID.ShadewoodGreaves),
				new ItemDefinition(ItemID.BorealWoodBreastplate),
				new ItemDefinition(ItemID.BorealWoodGreaves),
				new ItemDefinition(ItemID.PalmWoodBreastplate),
				new ItemDefinition(ItemID.PalmWoodGreaves),
				new ItemDefinition(ItemID.RichMahoganyBreastplate),
				new ItemDefinition(ItemID.RichMahoganyGreaves)
			};
		
		/*[Label("[i:Silk] Medium Cloth Rustle Whitelist")]*/
		public List<ItemDefinition> itemRustleClothMediumWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.CopperChainmail),
				new ItemDefinition(ItemID.CopperGreaves),
				new ItemDefinition(ItemID.TinChainmail),
				new ItemDefinition(ItemID.TinGreaves),
				new ItemDefinition(ItemID.IronChainmail),
				new ItemDefinition(ItemID.IronGreaves),
				new ItemDefinition(ItemID.LeadChainmail),
				new ItemDefinition(ItemID.LeadGreaves)
			};
		
		/*[Label("[i:Leather] Heavy Cloth Rustle Whitelist")]*/
		public List<ItemDefinition> itemRustleClothHeavyWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.SilverChainmail),
				new ItemDefinition(ItemID.SilverGreaves),
				new ItemDefinition(ItemID.TungstenChainmail),
				new ItemDefinition(ItemID.TungstenGreaves),
				new ItemDefinition(ItemID.GoldChainmail),
				new ItemDefinition(ItemID.GoldGreaves),
				new ItemDefinition(ItemID.PlatinumChainmail),
				new ItemDefinition(ItemID.PlatinumGreaves)
			};
		
		/*[Label("[i:Chain] Light Rattle Whitelist")]*/
		public List<ItemDefinition> itemRattleLightWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.CopperChainmail),
				new ItemDefinition(ItemID.CopperGreaves),
				new ItemDefinition(ItemID.TinChainmail),
				new ItemDefinition(ItemID.TinGreaves),
				new ItemDefinition(ItemID.IronChainmail),
				new ItemDefinition(ItemID.IronGreaves),
				new ItemDefinition(ItemID.LeadChainmail),
				new ItemDefinition(ItemID.LeadGreaves),
				new ItemDefinition(ItemID.Shackle)
			};
		
		/*[Label("[i:IronBar] Heavy Rattle Whitelist")]*/
		public List<ItemDefinition> itemRattleHeavyWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.SilverChainmail),
				new ItemDefinition(ItemID.SilverGreaves),
				new ItemDefinition(ItemID.TungstenChainmail),
				new ItemDefinition(ItemID.TungstenGreaves),
				new ItemDefinition(ItemID.GoldChainmail),
				new ItemDefinition(ItemID.GoldGreaves),
				new ItemDefinition(ItemID.PlatinumChainmail),
				new ItemDefinition(ItemID.PlatinumGreaves),
				new ItemDefinition(ItemID.BeetleShell),
				new ItemDefinition(ItemID.BeetleLeggings)
			};
		
		/*[Label("[i:SWATHelmet] Heavy Aramid Rustle Whitelist")]*/
		public List<ItemDefinition> itemRustleAramidHeavyWhitelist = new List<ItemDefinition>
			{
				new ItemDefinition(ItemID.BeetleShell),
				new ItemDefinition(ItemID.BeetleLeggings)
			};
		
        /*[Label("[i:HermesBoots] Left Foot Step Frame")]
        [Tooltip("[Default: 9]")]*/
        [Slider]
        [DefaultValue(9)]
        [Range(0, 19)]
        [Increment(1)]
        public int footStepLeft {get; set;}
		
        /*[Label("[i:HermesBoots] Right Foot Step Frame")]
        [Tooltip("[Default: 16]")]*/
        [Slider]
        [DefaultValue(16)]
        [Range(0, 19)]
        [Increment(1)]
        public int footStepRight {get; set;}
		
    }
}
