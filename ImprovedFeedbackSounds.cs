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
			public static readonly SoundStyle StepRubberFlipflop = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/StepRubberFlipflop", 2)
			{
				Volume = 0.25f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepLeatherBootLight = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/StepLeatherBootLight", 5)
			{
				Volume = 0.25f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepLeatherBootMedium = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/StepLeatherBootMedium", 12)
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle StepLeatherBootHeavy = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/StepLeatherBootHeavy", 5)
			{
				Volume = 2.00f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle JumpLeatherBootMedium = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/JumpLeatherBootMedium", 4)
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle LandLeatherBootLight = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/LandLeatherBootLight", 6)
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle LandLeatherBootMedium = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/LandLeatherBootMedium", 5)
			{
				Volume = 0.35f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle LandLeatherBootHeavy = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/LandLeatherBootHeavy")
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
			public static readonly SoundStyle RustleRattleLight = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/RustleRattleLight", 6)
			{
				Volume = 0.15f,
				PitchVariance = 0.15f,
				MaxInstances = 12
			};
			public static readonly SoundStyle RustleRattleHeavy = new($"{nameof(ImprovedFeedback)}/Assets/Sounds/Materials/RustleRattleHeavy", 5)
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