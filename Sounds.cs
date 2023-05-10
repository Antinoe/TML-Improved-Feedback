using Terraria.Audio;

namespace ImprovedFeedback
{
	public static partial class Sounds
	{
		public static class Player
		{
			public static readonly SoundStyle Step = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Step", 5)
			{
				Volume = 0.15f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle Skid = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Skid", 5)
			{
				Volume = 0.75f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepSandalGTA5 = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/GTA5/SandalStep", 2)
			{
				Volume = 0.25f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepBootGTA5 = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/GTA5/BootStep", 5)
			{
				Volume = 0.25f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle LandBootGTA5 = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/GTA5/BootLand", 6)
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepPowerSuitSuperMetroid = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/SuperMetroid/PowerSuitStep")
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle LandPowerSuitSuperMetroid = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/SuperMetroid/PowerSuitLand")
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepFusionSuitMetroidFusion = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/MetroidFusion/FusionSuitStep1")
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle JumpFusionSuitMetroidFusion = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/MetroidFusion/FusionSuitJump")
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle LandFusionSuitMetroidFusion = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/MetroidFusion/FusionSuitLand")
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepPraetorSuitDOOM2016 = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/DOOM2016/PraetorSuitStep", 12)
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle JumpPraetorSuitDOOM2016 = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/DOOM2016/PraetorSuitJump", 4)
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle LandPraetorSuitDOOM2016 = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/DOOM2016/PraetorSuitLand", 5)
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepMjolnirArmorHalo5 = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/Halo5/MjolnirArmorStep", 5)
			{
				Volume = 2.00f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle LandMjolnirArmorHalo5 = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/Footwear/Halo5/MjolnirArmorLand")
			{
				Volume = 1.00f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RustleClothLight = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/RustleClothLight", 7)
			{
				Volume = 0.05f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RustleClothMedium = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/RustleClothMedium", 7)
			{
				Volume = 0.15f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RustleClothHeavy = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/RustleClothHeavy", 4)
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RattleLight = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/RattleLight", 6)
			{
				Volume = 0.15f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RattleHeavy = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/RattleHeavy", 5)
			{
				Volume = 0.25f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RustleAramidHeavy = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/RustleAramidHeavy", 3)
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle HitWeak = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/HitWeak", 9)
			{
				Volume = 0.50f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle HitModerate = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/HitModerate", 5)
			{
				Volume = 0.50f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle HitHard = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/HitHard", 5)
			{
				Volume = 0.50f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
		}
	}
}
