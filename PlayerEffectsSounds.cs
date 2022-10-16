using Terraria.Audio;

namespace PlayerEffects
{
	public static partial class Sounds
	{
		public static class Player
		{
			public static readonly SoundStyle Step = new($"{nameof(PlayerEffects)}/Assets/Sounds/Step", 5)
			{
				Volume = 0.15f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepLeatherBootMedium = new($"{nameof(PlayerEffects)}/Assets/Sounds/Materials/StepLeatherBootMedium", 12)
			{
				Volume = 0.35f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepLeatherBootHeavy = new($"{nameof(PlayerEffects)}/Assets/Sounds/Materials/StepLeatherBootHeavy", 5)
			{
				Volume = 2.00f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle Jump = new($"{nameof(PlayerEffects)}/Assets/Sounds/Run", 4)
			{
				Volume = 0.15f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle JumpLeatherBootMedium = new($"{nameof(PlayerEffects)}/Assets/Sounds/Materials/JumpLeatherBootMedium", 4)
			{
				Volume = 0.35f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle Land = new($"{nameof(PlayerEffects)}/Assets/Sounds/Run", 4)
			{
				Volume = 0.15f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle LandLeatherBootMedium = new($"{nameof(PlayerEffects)}/Assets/Sounds/Materials/LandLeatherBootMedium", 5)
			{
				Volume = 0.35f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle LandLeatherBootHeavy = new($"{nameof(PlayerEffects)}/Assets/Sounds/Materials/LandLeatherBootHeavy")
			{
				Volume = 1.00f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RustleClothLight = new($"{nameof(PlayerEffects)}/Assets/Sounds/Materials/RustleClothLight", 7)
			{
				Volume = 0.05f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RustleClothMedium = new($"{nameof(PlayerEffects)}/Assets/Sounds/Materials/RustleClothMedium", 7)
			{
				Volume = 0.15f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RustleClothHeavy = new($"{nameof(PlayerEffects)}/Assets/Sounds/Materials/RustleClothHeavy", 2)
			{
				Volume = 0.35f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RustleAramidHeavy = new($"{nameof(PlayerEffects)}/Assets/Sounds/Materials/RustleAramidHeavy", 3)
			{
				Volume = 0.35f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
		}
	}
}