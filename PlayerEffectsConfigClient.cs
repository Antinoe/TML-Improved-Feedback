using System.Collections.Generic;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace PlayerEffects
{
    [Label("Client Config")]
    public class PlayerEffectsConfigClient : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ClientSide;
		
        public static PlayerEffectsConfigClient Instance;
		
	[Header("[i:Megaphone] Audio")]
		
        [Label("[i:Megaphone] Enable Sounds")]
        [Tooltip("If false, the sounds of this mod will not be played.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableSounds {get; set;}
		
        [Label("[i:Megaphone] Vanilla Sounds")]
        [Tooltip("If false, this mod's custom sounds will be played instead of Vanilla variations.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool enableVanillaSounds {get; set;}
		
        [Label("[i:StoneBlock] Enable Screenshake")]
        [Tooltip("If false, the effects of this mod will not produce Screenshake.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableScreenshake {get; set;}
		
        /*[Label("[i:HermesBoots] Left Foot Step Frame")]
        [Tooltip("[Default: 10]")]
        [Slider]
        [DefaultValue(10)]
        [Range(0, 19)]
        [Increment(1)]
        public int footStepLeft {get; set;}*/
		
    }
}