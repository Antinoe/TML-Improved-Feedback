using System; //This is so Math functions can work.
using Microsoft.Xna.Framework;
using Terraria;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.Mount;

namespace MovementEffects
{
    public class MovementEffectsPlayer : ModPlayer
    {
		protected bool stepping;
		protected bool inAir;
		protected bool jumping;
		protected bool landing;
		protected int screenShakeTimerVeryWeak;
		protected int screenShakeTimerWeak;
		protected int screenShakeTimerModerate;
		protected int screenShakeTimerStrong;
		
		public override void PostUpdateMiscEffects()
		{
			Player Player = Main.LocalPlayer;
			
			if (screenShakeTimerVeryWeak > 0)
			{
				screenShakeTimerVeryWeak--;
			}
			if (screenShakeTimerWeak > 0)
			{
				screenShakeTimerWeak--;
			}
			if (screenShakeTimerModerate > 0)
			{
				screenShakeTimerModerate--;
			}
			if (screenShakeTimerStrong > 0)
			{
				screenShakeTimerStrong--;
			}
			
			if (!Player.mount.Active)
			{
				//Stepping
				if (Player.legFrame.Y == Player.legFrame.Height * 10 || Player.legFrame.Y == Player.legFrame.Height * 16)
				{
					if (!stepping)
					{
						stepping = true;
						if (MovementEffectsConfigClient.Instance.enableSounds)
						{
							SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
						}
					}
				}
				else
				{
					stepping = false;
				}
				//Jumping
				if (Player.velocity.Y < 0 && Player.controlJump)
				{
					if (!jumping)
					{
						jumping = true;
						if (MovementEffectsConfigClient.Instance.enableSounds)
						{
							SoundEngine.PlaySound(Sounds.Player.Jump, Player.position);
						}
					}
				}
				else
				{
					jumping = false;
				}
				//Falling
				if (Player.velocity.Y > 10)
				{
					if (MovementEffectsConfigClient.Instance.enableScreenshake)
					{
						screenShakeTimerWeak = 5;
					}
				}
				//Landing
				if (Player.velocity.Y == 0)
				{
					if (!landing)
					{
						landing = true;
						if (MovementEffectsConfigClient.Instance.enableSounds)
						{
							SoundEngine.PlaySound(Sounds.Player.Land, Player.position);
						}
						if (MovementEffectsConfigClient.Instance.enableScreenshake)
						{
							screenShakeTimerVeryWeak = 10;
						}
					}
				}
				else
				{
					landing = false;
				}
			}
		}
		
		public override void ModifyScreenPosition()
		{
            if (screenShakeTimerVeryWeak > 0)
            {
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.10f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.10f);
            }
            if (screenShakeTimerWeak > 0)
            {
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.30f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.30f);
            }
            if (screenShakeTimerModerate > 0)
            {
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.50f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.50f);
            }
            if (screenShakeTimerStrong > 0)
            {
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.70f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.70f);
            }
		}
    }
}