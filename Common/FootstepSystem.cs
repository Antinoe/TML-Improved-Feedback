using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using static Terraria.Mount;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
//	This will be used for Screenshake.
using Terraria.Graphics.CameraModifiers;

namespace ImprovedFeedback.Common{
	public class EquipmentCheck : GlobalItem{
		public override void UpdateEquip(Item item, Player player){
			FootstepPlayer ifp = player.GetModPlayer<FootstepPlayer>();
			//if (item.type == ItemID.WoodGreaves){ifp.itemHalfLife2=true;}
			if (FootstepConfig.Instance.itemPresenceFootsteps.Contains(new ItemDefinition(item.type))){ifp.itemPresenceFootsteps=true;}
			if (FootstepConfig.Instance.itemCloth.Contains(new ItemDefinition(item.type))){ifp.itemCloth=true;}
			if (FootstepConfig.Instance.itemSlime.Contains(new ItemDefinition(item.type))){ifp.itemSlime=true;}
			if (FootstepConfig.Instance.itemChainmail.Contains(new ItemDefinition(item.type))){ifp.itemChainmail=true;}
			if (FootstepConfig.Instance.itemPlate.Contains(new ItemDefinition(item.type))){ifp.itemPlate=true;}
			if (FootstepConfig.Instance.itemPlateFoot.Contains(new ItemDefinition(item.type))){ifp.itemPlateFoot=true;}
			if (FootstepConfig.Instance.itemCrystal.Contains(new ItemDefinition(item.type))){ifp.itemCrystal=true;}
			if (FootstepConfig.Instance.itemCrystalFoot.Contains(new ItemDefinition(item.type))){ifp.itemCrystalFoot=true;}
			if (FootstepConfig.Instance.itemHalfLife2.Contains(new ItemDefinition(item.type))){ifp.itemHalfLife2=true;}
			if (FootstepConfig.Instance.itemHalo5.Contains(new ItemDefinition(item.type))){ifp.itemHalo5=true;}
		}
		public override void UpdateVanity(Item item, Player player){
			FootstepPlayer ifp = player.GetModPlayer<FootstepPlayer>();
			if (FootstepConfig.Instance.itemPresenceFootsteps.Contains(new ItemDefinition(item.type))){ifp.itemPresenceFootsteps=true;}
			if (FootstepConfig.Instance.itemCloth.Contains(new ItemDefinition(item.type))){ifp.itemCloth=true;}
			if (FootstepConfig.Instance.itemSlime.Contains(new ItemDefinition(item.type))){ifp.itemSlime=true;}
			if (FootstepConfig.Instance.itemChainmail.Contains(new ItemDefinition(item.type))){ifp.itemChainmail=true;}
			if (FootstepConfig.Instance.itemPlate.Contains(new ItemDefinition(item.type))){ifp.itemPlate=true;}
			if (FootstepConfig.Instance.itemPlateFoot.Contains(new ItemDefinition(item.type))){ifp.itemPlateFoot=true;}
			if (FootstepConfig.Instance.itemCrystal.Contains(new ItemDefinition(item.type))){ifp.itemCrystal=true;}
			if (FootstepConfig.Instance.itemCrystalFoot.Contains(new ItemDefinition(item.type))){ifp.itemCrystalFoot=true;}
			if (FootstepConfig.Instance.itemHalfLife2.Contains(new ItemDefinition(item.type))){ifp.itemHalfLife2=true;}
			if (FootstepConfig.Instance.itemHalo5.Contains(new ItemDefinition(item.type))){ifp.itemHalo5=true;}
		}
	}
	public class FootstepPlayer : ModPlayer{
		public bool stepping;
		public bool skidding;
		public bool jumping;
		public bool landing;
		public bool hasFootwear;
		public bool itemCloth;
		public bool itemSlime;
		public bool itemChainmail;
		public bool itemPlate;
		public bool itemPlateFoot;
		public bool itemCrystal;
		public bool itemPresenceFootsteps;
		public bool itemCrystalFoot;
		public bool itemHalfLife2;
		public bool itemHalo5;
		public override void ResetEffects(){
			//stepping=false;
			//jumping=false;
			//landing=false;
			hasFootwear=false;
			itemCloth=false;
			itemSlime=false;
			itemChainmail=false;
			itemPlate=false;
			itemPlateFoot=false;
			itemCrystal=false;
			itemCrystalFoot=false;
			itemPresenceFootsteps=false;
			itemHalfLife2=false;
			itemHalo5=false;
		}
		public override void PostUpdateMiscEffects(){
			var player = Player;
			//	I'll need to improve this if I want to give other developers the ability to make their own footstep items.
			hasFootwear = (itemPresenceFootsteps || itemHalfLife2 || itemHalo5);
				//	Jumping
				//if (player.velocity.Y < 0 && player.controlJump){
				if (player.controlJump){
					if (!jumping){
						jumping = true;
						Jump(player);
					}
				}
				else{jumping = false;}
				//	Landing
				if (player.velocity.Y == 0){
					if (!landing){
						landing = true;
						Land(player);
					}
				}
				else{landing = false;}
		}
		public virtual void Jump(Player player){}
		public virtual void Land(Player player){}
	}
	public class FootstepTile : GlobalTile{
		public override void FloorVisuals(int type, Player player){
			var ifp = player.GetModPlayer<FootstepPlayer>();
			if (!player.mount.Active){
				//	Stepping
				if(player.legFrame.Y == player.legFrame.Height * FootstepConfig.Instance.LegFrame1 || player.legFrame.Y == player.legFrame.Height * FootstepConfig.Instance.LegFrame2){
					if (!ifp.stepping){
						ifp.stepping = true;
						if(FootstepConfig.Instance.FootstepsToggle){Step(type, player);	Rustle(player);}
					}
				}
				else{ifp.stepping = false;}
				//	Skidding
				if (player.velocity.X == 0 && player.velocity.Y == 0){
					if (!ifp.skidding){
						ifp.skidding = true;
						if(FootstepConfig.Instance.FootstepsToggle){Step(type, player);	Rustle(player);}
					}
				}
				else{ifp.skidding = false;}
			}
		}
		public virtual void Step(int type, Player player){
			//	..Because the Terraria devs didn't think a Wood Set was necessary. :moyai:
			bool isWood = (type == TileID.WoodBlock || type == TileID.Ebonwood || type == TileID.Pearlwood || type == TileID.Shadewood || type == TileID.SpookyWood || type == TileID.DynastyWood || type == TileID.BorealWood || type == TileID.PalmWood || type == TileID.AshWood);
			bool isSand = (type == TileID.Sand || type == TileID.Ebonsand || type == TileID.Crimsand);
			bool isMetal = (type == TileID.MetalBars);
			//if(type == TileID.Sets.AllTiles){StepOnSnow(player);}
			bool isAnyTile = (TileID.Sets.AllTiles[type]);
			bool isAsh = (TileID.Sets.Ash[type]);
			bool isOre = (TileID.Sets.Ore[type]);
			bool isMud = (TileID.Sets.Mud[type]);
			bool isIce = (TileID.Sets.Ices[type]);
			bool isSnow = (TileID.Sets.Snow[type] || TileID.Sets.IcesSnow[type] || TileID.Sets.IcesSlush[type]);
			bool isDirt = (TileID.Sets.Dirt[type]);
			bool isGrass = (TileID.Sets.Grass[type]);
			bool isStone = (TileID.Sets.Stone[type] || TileID.Sets.CrackedBricks[type] || TileID.Sets.Boulders[type]);
			bool isLeaves = (TileID.Sets.Leaves[type]);
			bool isClouds = (TileID.Sets.Clouds[type]);
			if(isAnyTile){StepOnAnyTile(player);}
			if(isAsh){StepOnSand(player);}
			if(isOre){StepOnMetalBar(player);}
			if(isMetal){StepOnMetalBar(player);}
			if(isMud){StepOnMud(player);}
			if(isIce){StepOnDirt(player);}
			if(isSand){StepOnSand(player);}
			if(isSnow){StepOnSand(player);}
			if(isDirt){StepOnDirt(player);}
			if(isGrass){StepOnGrass(player);}
			if(isStone){StepOnStone(player);}
			if(isLeaves){StepOnLeaves(player);}
			if(isClouds){StepOnSand(player);}
			if(isWood){StepOnWood(player);}
		}
		public virtual void Rustle(Player player){
			var ifp = player.GetModPlayer<FootstepPlayer>();
			if(ifp.itemCloth){SoundEngine.PlaySound(Sounds.DynamicSurroundings.Light, player.position);}
			if(ifp.itemSlime){SoundEngine.PlaySound(Sounds.DynamicSurroundings.SlimeWalk, player.position);}
			if(ifp.itemChainmail){SoundEngine.PlaySound(Sounds.DynamicSurroundings.MediumWalk, player.position);}
			if(ifp.itemPlate){SoundEngine.PlaySound(Sounds.DynamicSurroundings.HeavyWalk, player.position);}
			if(ifp.itemPlateFoot){SoundEngine.PlaySound(Sounds.DynamicSurroundings.HeavyFoot, player.position);}
			if(ifp.itemCrystal){SoundEngine.PlaySound(Sounds.DynamicSurroundings.CrystalWalk, player.position);}
			if(ifp.itemCrystalFoot){SoundEngine.PlaySound(Sounds.DynamicSurroundings.CrystalFoot, player.position);}
		}
		//	Old sound functions. All use stock Vanilla sounds.
		/*
		public virtual void StepOnGrass(Player player){SoundEngine.PlaySound(SoundID.Grab with {Volume=1f,Pitch=1.25f},player.position);}
		public virtual void StepOnDirt(Player player){SoundEngine.PlaySound(SoundID.Dig with {Volume=1f,Pitch=2f},player.position);}
		public virtual void StepOnMud(Player player){SoundEngine.PlaySound(SoundID.NPCHit6 with {Volume=1f,Pitch=1.5f},player.position);}
		public virtual void StepOnLeaves(Player player){SoundEngine.PlaySound(SoundID.Grass with {Volume=1f,Pitch=1.25f},player.position);}
		public virtual void StepOnSand(Player player){SoundEngine.PlaySound(SoundID.Run with {Volume=1f,Pitch=1.5f},player.position);}
		public virtual void StepOnSnow(Player player){SoundEngine.PlaySound(SoundID.Run with {Volume=1f,Pitch=1.5f},player.position);}
		public virtual void StepOnStone(Player player){SoundEngine.PlaySound(SoundID.Dig with {Volume=1f,Pitch=1f},player.position);}
		public virtual void StepOnWood(Player player){SoundEngine.PlaySound(SoundID.Dig with {Volume=1f,Pitch=0.25f},player.position);}
		public virtual void StepOnMetal(Player player){SoundEngine.PlaySound(SoundID.Tink with {Volume=1f,Pitch=1.25f},player.position);}
		*/
		//	Really need to change these..
		//	There probably shouldn't be dozens of different hooks. It may be better if this were all in Step().
		public virtual void StepOnAnyTile(Player player){
		}
		public virtual void StepOnBluntWood(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.Skyrim.Wood, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.WoodWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Regular, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Wood, player.position);}
		}
		public virtual void StepOnBrush(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.BrushThrough, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.BrushThrough, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Nature, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Grass, player.position);}
		}
		public virtual void StepOnChain(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.Chain, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.Chain, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Regular, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.ChainLink, player.position);}
		}
		public virtual void StepOnConcrete(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.Skyrim.Stone, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.ConcreteWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Regular, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Concrete, player.position);}
		}
		public virtual void StepOnDirt(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.DirtWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.DirtWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Nature, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Dirt, player.position);}
		}
		public virtual void StepOnGlass(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.Skyrim.Stone, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.Glass, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Tile, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Tile, player.position);}
		}
		public virtual void StepOnGrass(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.GrassWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.GrassWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Nature, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Grass, player.position);}
		}
		public virtual void StepOnGravel(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.GravelWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.GravelWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Nature, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Gravel, player.position);}
		}
		public virtual void StepOnLeaves(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.LeavesThrough, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.LeavesThrough, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.PresenceFootsteps.LeavesThrough, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Grass, player.position);}
		}
		public virtual void StepOnLino(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.Skyrim.Stone, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.LinoWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Tile, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Tile, player.position);}
		}
		public virtual void StepOnMarble(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.Skyrim.Stone, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.MarbleWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Tile, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Tile, player.position);}
		}
		public virtual void StepOnMetalBar(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.Skyrim.Stone, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.MetalBarWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Regular, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Metal, player.position);}
		}
		public virtual void StepOnMetalBox(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.Skyrim.Stone, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.MetalBoxWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Regular, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Duct, player.position);}
		}
		public virtual void StepOnMud(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.MudWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.MudWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.PresenceFootsteps.MudWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Mud, player.position);}
		}
		public virtual void StepOnMuffledIce(Player player){
			//	Maybe barefoot here too?
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.MuffledIceWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.MuffledIceWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.PresenceFootsteps.MuffledIceWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Concrete, player.position);}
		}
		public virtual void StepOnQuickSand(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.QuickSandWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.QuickSandWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.PresenceFootsteps.QuickSandWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Sand, player.position);}
		}
		public virtual void StepOnRug(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.RugWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.RugWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Regular, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.WoodPanel, player.position);}
		}
		public virtual void StepOnSand(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.SandWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.SandWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.PresenceFootsteps.SandWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Sand, player.position);}
		}
		public virtual void StepOnSnow(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.SnowWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.SnowWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.PresenceFootsteps.SnowWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Sand, player.position);}
		}
		public virtual void StepOnSqueakyWood(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.Skyrim.Wood, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.SqueakyWoodWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Regular, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.WoodPanel, player.position);}
		}
		public virtual void StepOnStone(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.Skyrim.Stone, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.StoneWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Regular, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Concrete, player.position);}
		}
		public virtual void StepOnWater(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.WaterThrough, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.PresenceFootsteps.WaterThrough, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Slosh, player.position);}
		}
		public virtual void StepOnWeakIce(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.PresenceFootsteps.WeakIceWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.PresenceFootsteps.WeakIceWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Concrete, player.position);}
		}
		public virtual void StepOnWood(Player player){
			if (!player.GetModPlayer<FootstepPlayer>().hasFootwear){SoundEngine.PlaySound(Sounds.Skyrim.Wood, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemPresenceFootsteps){SoundEngine.PlaySound(Sounds.PresenceFootsteps.WoodWalk, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalo5){SoundEngine.PlaySound(Sounds.Halo5.Regular, player.position);}
			if (player.GetModPlayer<FootstepPlayer>().itemHalfLife2){SoundEngine.PlaySound(Sounds.HalfLife2.Wood, player.position);}
		}
	}
}
