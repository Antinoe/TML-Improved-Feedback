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

namespace ImprovedFeedback
{
    public class ImprovedFeedbackPlayer : ModPlayer
    {
		public bool stepping;
		public bool skidding;
		public bool inAir;
		public bool jumping;
		public bool landing;
		public bool itemRustleClothLight;
		public bool itemRustleClothMedium;
		public bool itemRustleClothHeavy;
		public bool itemRustleRattleLight;
		public bool itemRustleRattleHeavy;
		public bool itemRustleAramidHeavy;
		public bool itemStepRubberFlipflop;
		public bool itemStepLeatherBootLight;
		public bool itemStepLeatherBootMedium;
		public bool itemStepLeatherBootHeavy;
		public int screenShakeTimerVeryWeak;
		public int screenShakeTimerWeak;
		public int screenShakeTimerModerate;
		public int screenShakeTimerStrong;
		
        public override void ResetEffects()
        {
			itemRustleClothLight = false;
			itemRustleClothMedium = false;
			itemRustleClothHeavy = false;
			itemRustleRattleLight = false;
			itemRustleRattleHeavy = false;
			itemRustleAramidHeavy = false;
			itemStepRubberFlipflop = false;
			itemStepLeatherBootLight = false;
			itemStepLeatherBootMedium = false;
			itemStepLeatherBootHeavy = false;
        }
		
		public override void PostUpdateMiscEffects()
		{
			//var Player = Main.LocalPlayer;
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
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
				if (Player.legFrame.Y == Player.legFrame.Height * 9 || Player.legFrame.Y == Player.legFrame.Height * 16)
				{
					if (!stepping)
					{
						stepping = true;
						OnStep();
					}
				}
				else
				{
					stepping = false;
				}
				//Skidding
				if (Player.velocity.X == 0 && Player.velocity.Y == 0)
				{
					if (!skidding)
					{
						skidding = true;
						OnSkid();
					}
				}
				else
				{
					skidding = false;
				}
				//Jumping
				if (Player.velocity.Y < 0 && Player.controlJump)
				{
					if (!jumping)
					{
						jumping = true;
					}
				}
				else
				{
					jumping = false;
				}
				//Falling
				if (Player.velocity.Y > 10)
				{
					OnFalling();
				}
				//Landing
				if (Player.velocity.Y == 0)
				{
					if (!landing)
					{
						landing = true;
						OnLand();
					}
				}
				else
				{
					landing = false;
				}
			}
		}
		
		/*
		//	Actions called from PostUpdateMiscEffects.
		*/
		
		public void OnStep()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClient.Instance.enableSounds)
			{
				//I'm well aware of how unoptimized this file is. I'll fix it soon.
				if (!ifp.itemStepRubberFlipflop && !ifp.itemStepLeatherBootLight && !ifp.itemStepLeatherBootMedium && !ifp.itemStepLeatherBootHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
				}
				else
				{
					if (ifp.itemStepRubberFlipflop)
					{
						SoundEngine.PlaySound(Sounds.Player.StepRubberFlipflop, Player.position);
					}
					if (ifp.itemStepLeatherBootLight)
					{
						SoundEngine.PlaySound(Sounds.Player.StepLeatherBootLight, Player.position);
					}
					if (ifp.itemStepLeatherBootMedium)
					{
						SoundEngine.PlaySound(Sounds.Player.StepLeatherBootMedium, Player.position);
					}
					if (ifp.itemStepLeatherBootHeavy)
					{
						SoundEngine.PlaySound(Sounds.Player.StepLeatherBootHeavy, Player.position);
					}
				}
				if (ifp.itemRustleClothLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothLight, Player.position);
				}
				if (ifp.itemRustleClothMedium)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothMedium, Player.position);
				}
				if (ifp.itemRustleClothHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothHeavy, Player.position);
				}
				if (ifp.itemRustleRattleLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleRattleLight, Player.position);
				}
				if (ifp.itemRustleRattleHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleRattleHeavy, Player.position);
				}
				if (ifp.itemRustleAramidHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleAramidHeavy, Player.position);
				}
			}
		}
		public void OnSkid()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClient.Instance.enableSounds)
			{
				if (!ifp.itemStepRubberFlipflop && !ifp.itemStepLeatherBootLight && !ifp.itemStepLeatherBootMedium && !ifp.itemStepLeatherBootHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
				}
				else
				{
					SoundEngine.PlaySound(Sounds.Player.Skid, Player.position);
				}
			}
		}
		public void OnJump()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClient.Instance.enableSounds)
			{
				if (!ifp.itemStepRubberFlipflop && !ifp.itemStepLeatherBootLight && !ifp.itemStepLeatherBootMedium && !ifp.itemStepLeatherBootHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
				}
				else
				{
					if (ifp.itemStepRubberFlipflop)
					{
						SoundEngine.PlaySound(Sounds.Player.StepRubberFlipflop, Player.position);
					}
					if (ifp.itemStepLeatherBootLight)
					{
						SoundEngine.PlaySound(Sounds.Player.LandLeatherBootLight, Player.position);
					}
					if (ifp.itemStepLeatherBootMedium)
					{
						SoundEngine.PlaySound(Sounds.Player.JumpLeatherBootMedium, Player.position);
					}
					if (ifp.itemStepLeatherBootHeavy)
					{
						SoundEngine.PlaySound(Sounds.Player.LandLeatherBootHeavy, Player.position);
					}
				}
				if (ifp.itemRustleClothLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothLight, Player.position);
				}
				if (ifp.itemRustleClothMedium)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothMedium, Player.position);
				}
				if (ifp.itemRustleClothHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothHeavy, Player.position);
				}
				if (ifp.itemRustleRattleLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleRattleLight, Player.position);
				}
				if (ifp.itemRustleRattleHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleRattleHeavy, Player.position);
				}
				if (ifp.itemRustleAramidHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleAramidHeavy, Player.position);
				}
			}
		}
		public void OnFalling()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClient.Instance.enableScreenshake)
			{
				screenShakeTimerWeak = 5;
			}
		}
		public void OnLand()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClient.Instance.enableSounds)
			{
				if (!ifp.itemStepRubberFlipflop && !ifp.itemStepLeatherBootLight && !ifp.itemStepLeatherBootMedium && !ifp.itemStepLeatherBootHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
					SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
				}
				else
				{
					if (ifp.itemStepRubberFlipflop)
					{
						SoundEngine.PlaySound(Sounds.Player.StepRubberFlipflop, Player.position);
						SoundEngine.PlaySound(Sounds.Player.StepRubberFlipflop, Player.position);
					}
					if (ifp.itemStepLeatherBootLight)
					{
						SoundEngine.PlaySound(Sounds.Player.LandLeatherBootLight, Player.position);
					}
					if (ifp.itemStepLeatherBootMedium)
					{
						SoundEngine.PlaySound(Sounds.Player.LandLeatherBootMedium, Player.position);
					}
					if (ifp.itemStepLeatherBootHeavy)
					{
						SoundEngine.PlaySound(Sounds.Player.LandLeatherBootHeavy, Player.position);
						SoundEngine.PlaySound(Sounds.Player.LandLeatherBootHeavy, Player.position);
					}
				}
				if (ifp.itemRustleClothLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothLight, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RustleClothLight, Player.position);
				}
				if (ifp.itemRustleClothMedium)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothMedium, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RustleClothMedium, Player.position);
				}
				if (ifp.itemRustleClothHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothHeavy, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RustleClothHeavy, Player.position);
				}
				if (ifp.itemRustleRattleLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleRattleLight, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RustleRattleLight, Player.position);
				}
				if (ifp.itemRustleRattleHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleRattleHeavy, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RustleRattleHeavy, Player.position);
				}
				if (ifp.itemRustleAramidHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleAramidHeavy, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RustleAramidHeavy, Player.position);
				}
			}
			if (ImprovedFeedbackConfigClient.Instance.enableScreenshake)
			{
				screenShakeTimerVeryWeak = 10;
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
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.50f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.50f);
            }
            if (screenShakeTimerModerate > 0)
            {
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 2.00f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 2.00f);
            }
            if (screenShakeTimerStrong > 0)
            {
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 4.00f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 4.00f);
            }
		}
		
		public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource, ref int cooldownCounter)
		{
			if (ImprovedFeedbackConfigClient.Instance.enableDynamicDamageEffects)
			{
				playSound = false;
			}
			return true;
		}
		public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit, int cooldownCounter)
		{
			if (ImprovedFeedbackConfigClient.Instance.enableDynamicDamageEffects)
			{
				//if (damage == (int)(Player.statLifeMax * 0.25))
				if (damage > 0 && damage < 5)
				{
					SoundEngine.PlaySound(Sounds.Player.HitWeak, Player.position);
					if (ImprovedFeedbackConfigClient.Instance.enableScreenshake)	{screenShakeTimerWeak = 10;}
				}
				//if (damage == (int)(Player.statLifeMax * 0.50))
				if (damage >= 5 && damage < 15)
				{
					SoundEngine.PlaySound(Sounds.Player.HitModerate, Player.position);
					if (ImprovedFeedbackConfigClient.Instance.enableScreenshake)	{screenShakeTimerModerate = 15;}
				}
				//if (damage == (int)(Player.statLifeMax * 0.75))
				if (damage >= 15)
				{
					SoundEngine.PlaySound(Sounds.Player.HitHard, Player.position);
					if (ImprovedFeedbackConfigClient.Instance.enableScreenshake)	{screenShakeTimerStrong = 20;}
				}
			}
		}
    }
}