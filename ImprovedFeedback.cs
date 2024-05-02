using Terraria.Audio;
using Terraria.ModLoader;

namespace ImprovedFeedback{
	public class ImprovedFeedback : Mod{}
	public static partial class Sounds{
		public static class Skyrim{
			public static readonly SoundStyle Stone = new SoundStyle("ImprovedFeedback/Assets/Sounds/Skyrim/Footsteps/fst_player_barefoot_stonesolid_walk_0",6){Volume=1f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Wood = new SoundStyle("ImprovedFeedback/Assets/Sounds/Skyrim/Footsteps/fst_player_barefoot_wood_walk_0",6){Volume=1f,PitchVariance=0.5f,MaxInstances=10};
		}
		public static class DynamicSurroundings{
			public static readonly SoundStyle CrystalFoot = new SoundStyle("ImprovedFeedback/Assets/Sounds/DynamicSurroundings/Armor/crystal_foot",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle CrystalWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/DynamicSurroundings/Armor/crystal_walk",6){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle HeavyFoot = new SoundStyle("ImprovedFeedback/Assets/Sounds/DynamicSurroundings/Armor/heavy_foot",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle HeavyWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/DynamicSurroundings/Armor/heavy_walk",6){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Light = new SoundStyle("ImprovedFeedback/Assets/Sounds/DynamicSurroundings/Armor/light_",3){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MediumWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/DynamicSurroundings/Armor/medium_walk",3){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle SlimeWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/DynamicSurroundings/Armor/slime_walk",6){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
		}
		public static class PresenceFootsteps{
			public static readonly SoundStyle BluntWoodWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/BluntWood/bluntwood_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle BluntWoodWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/BluntWood/bluntwood_wander",5){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle BrushThrough = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Brush/brush_through",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Chain = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Chain/chain_",12){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle ConcreteWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Concrete/concrete_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle ConcreteWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Concrete/concrete_wander",5){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle DirtWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Dirt/dirt_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle DirtWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Dirt/dirt_wander",5){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Glass = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Glass/glass_hit",2){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle GrassWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Grass/grass_walk",10){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle GrassWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Grass/grass_wander",6){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle GravelWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Gravel/gravel_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle GravelWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Gravel/gravel_wander",3){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle LeavesThrough = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Leaves/leaves_through",7){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle LinoWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Lino/lino_walk",8){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MarbleWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Marble/marble_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MarbleWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Marble/marble_wander",7){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MetalBarWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/MetalBar/metalbar_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MetalBarWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/MetalBar/metalbar_wander",6){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MetalBoxWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/MetalBox/metalbox_walk",9){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MetalBoxWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/MetalBox/metalbox_wander",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MudWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Mud/mud_walk",6){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MudWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Mud/mud_wander",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MuffledIceWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/MuffledIce/muffledice_walk",10){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle QuickSandWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/QuickSand/quicksand_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle RugWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Rug/rug_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle SandWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Sand/sand_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle SnowWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Snow/snow_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle SnowWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Snow/snow_wander",5){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle SqueakyWoodWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/SqueakyWood/squeakywood_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle SqueakyWoodWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/SqueakyWood/squeakywood_wander",7){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle StoneWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Stone/stone_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle StoneWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Stone/stone_wander",5){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle WaterThrough = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Water/water_through",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle WaterWander = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Water/water_wander",5){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle WeakIceWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/WeakIce/weakice_walk",10){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle WoodWalk = new SoundStyle("ImprovedFeedback/Assets/Sounds/PresenceFootsteps/Wood/wood_walk",11){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
		}
		public static class HalfLife2{
			public static readonly SoundStyle ChainLink = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/chainlink",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Concrete = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/concrete",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Dirt = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/dirt",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Duct = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/duct",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Grass = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/grass",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Gravel = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/gravel",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Ladder = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/ladder",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Metal = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/metal",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle MetalGrate = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/metalgrate",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Mud = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/mud",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Sand = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/sand",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Slosh = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/slosh",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Tile = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/tile",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Wade = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/wade",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Wood = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/wood",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle WoodPanel = new SoundStyle("ImprovedFeedback/Assets/Sounds/HalfLife2/Footsteps/woodpanel",4){Volume=0.5f,PitchVariance=0.5f,MaxInstances=10};
		}
		public static class Halo5{
			public static readonly SoundStyle Tile = new SoundStyle("ImprovedFeedback/Assets/Sounds/Halo5/Footsteps/H5_Footstep_Breakout_Tile_",10){Volume=1f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Glass = new SoundStyle("ImprovedFeedback/Assets/Sounds/Halo5/Footsteps/H5_Footstep_Glass_",10){Volume=1f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Nature = new SoundStyle("ImprovedFeedback/Assets/Sounds/Halo5/Footsteps/H5_Footstep_Nature_",10){Volume=1f,PitchVariance=0.5f,MaxInstances=10};
			public static readonly SoundStyle Regular = new SoundStyle("ImprovedFeedback/Assets/Sounds/Halo5/Footsteps/H5_Footstep_Regular_",6){Volume=1f,PitchVariance=0.5f,MaxInstances=10};
		}
	}
}
