using Terraria.Audio;

namespace MovementEffects
{
	public static partial class Sounds
	{
		public static class Player
		{
			public static readonly SoundStyle Step = new($"{nameof(MovementEffects)}/Assets/Sounds/Step", 12)
			{
				Volume = 0.35f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle Jump = new($"{nameof(MovementEffects)}/Assets/Sounds/Jump", 4)
			{
				Volume = 0.15f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
			public static readonly SoundStyle Land = new($"{nameof(MovementEffects)}/Assets/Sounds/Land", 5)
			{
				Volume = 0.15f,
				PitchVariance = 0.5f,
				MaxInstances = 12
			};
		}
	}
}