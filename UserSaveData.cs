namespace ArkhamRevivedSelfHosted;

public class UserSaveData
{
    public SaveData data { get; set; }
}

public class SaveData
{
    public int ControllerSensitivity { get; set; }
    public string GameDifficulty { get; set; }
    public bool AutoAim { get; set; }
    public bool AutoCenter { get; set; }
    public string MovementControl { get; set; }
    public bool YInversion { get; set; }
    public bool Subtitles { get; set; }
    public bool Tutorial { get; set; }
    public bool Hints { get; set; }
    public int Gamma { get; set; }
    public int VolumeSFX { get; set; }
    public int VolumeMusic { get; set; }
    public int VolumeDialogue { get; set; }
    public bool InvertRotation { get; set; }
    public bool InvertGlide { get; set; }
    public bool InvertBatarang { get; set; }
    public bool ControllerVibration { get; set; }
    public bool CameraAssist { get; set; }
    public int AccountXP { get; set; }
    public int AccountXPForPrevUpgrade { get; set; }
    public int AccountXPForNextUpgrade { get; set; }
    public int AccountXPLevel { get; set; }
    public string EquippedWeapon1 { get; set; }
    public string EquippedWeapon2 { get; set; }
    public bool ForceEquipGoldenShotgun { get; set; }
    public bool ForceEquipRifle { get; set; }
    public int jokerXP { get; set; }
    public int jokerXPForPrevUpgrade { get; set; }
    public int jokerXPForNextUpgrade { get; set; }
    public int jokerXPLevel { get; set; }
    public int baneXP { get; set; }
    public int baneXPForPrevUpgrade { get; set; }
    public int baneXPForNextUpgrade { get; set; }
    public int baneXPLevel { get; set; }
    public CustomizationProfileData CustomizationProfileData { get; set; }
    public int PrestigeLevel { get; set; }
    public int PrestigeWeapon { get; set; }
    public int L0Team { get; set; }
    public int L0Weap { get; set; }
    public int L0PadL { get; set; }
    public int L0PadR { get; set; }
    public int L0char { get; set; }
    public int L1Team { get; set; }
    public int L1Weap { get; set; }
    public int L1PadL { get; set; }
    public int L1PadR { get; set; }
    public int L1char { get; set; }
    public int PreferredFaction { get; set; }
    public bool WeaponAutoSwitch { get; set; }
    public LoadoutData LoadoutData { get; set; }
    public int LoadoutDataVersion { get; set; }
    public int ControlType { get; set; }
    public bool LeftyFlip { get; set; }
    public bool TriggerFlip { get; set; }
    public double ThugXAxisSens { get; set; }
    public double ThugYAxisSens { get; set; }
    public int RoundsSinceHero { get; set; }
    public bool HeroOptOut { get; set; }
    public bool MapRoundWin_Chemplant_Bane { get; set; }
    public bool MapRoundWin_Chemplant_Joker { get; set; }
    public bool MapRoundWin_Chemplant_Hero { get; set; }
    public bool MapRoundWin_Blackgate_Bane { get; set; }
    public bool MapRoundWin_Blackgate_Joker { get; set; }
    public bool MapRoundWin_Blackgate_Hero { get; set; }
    public bool MapRoundWin_Funhouse_Bane { get; set; }
    public bool MapRoundWin_Funhouse_Joker { get; set; }
    public bool MapRoundWin_Funhouse_Hero { get; set; }
    public bool MapRoundWin_RobotFactory_Bane { get; set; }
    public bool MapRoundWin_RobotFactory_Joker { get; set; }
    public bool MapRoundWin_RobotFactory_Hero { get; set; }
    public int HeroKillsOnElites { get; set; }
    public int EliteKillsOnHeroes { get; set; }
    public bool FirstBoot { get; set; }
    public bool IPOTutorialVideo_Watched { get; set; }
    public bool HHTutorialVideo_Watched { get; set; }
    public string LastModified { get; set; }
    public bool UseSixaxisControls { get; set; }
    public RecentUnlocks RecentUnlocks { get; set; }
    public bool JokerIndoc1Video_Watched { get; set; }
    public bool JokerIndoc2Video_Watched { get; set; }
    public bool BaneIndoc1Video_Watched { get; set; }
    public bool BaneIndoc2Video_Watched { get; set; }
    public int MatchmakingDataVersion { get; set; }
    public MatchmakingData MatchmakingData { get; set; }
    public bool SkippedWBIDPrompt { get; set; }
    public WeaponScores WeaponScores { get; set; }
    public bool WeaponCache_Satchel1 { get; set; }
    public bool WeaponCache_Case1 { get; set; }
    public bool WeaponCache_Case2 { get; set; }
    public bool WeaponCache_Crate1 { get; set; }
    public bool WeaponCache_Crate2 { get; set; }
    public bool WeaponCache_Container1 { get; set; }
    public bool SPSkin_New52Graphic { get; set; }
    public bool SPSkin_Noel { get; set; }
    public bool SPSkin_DarkKnight { get; set; }
    public bool GotWBIDBonus { get; set; }
    public bool SkipWBIDLinkage { get; set; }
    public int WBIDPrivacyGuid1 { get; set; }
    public bool SPSkin_RedSon { get; set; }
    public bool MPSkin_BlackestNight { get; set; }
    public int WBIDPrivacyGuid2 { get; set; }
    public int WBIDPrivacyGuid3 { get; set; }
    public int WBIDPrivacyGuid4 { get; set; }
    public bool WeaponCache_Satchel1_Redeemed { get; set; }
    public bool WeaponCache_Case1_Redeemed { get; set; }
    public bool WeaponCache_Case2_Redeemed { get; set; }
    public bool WeaponCache_Crate1_Redeemed { get; set; }
    public bool WeaponCache_Crate2_Redeemed { get; set; }
    public bool WeaponCache_Container1_Redeemed { get; set; }
    public bool SPTrophyRobin { get; set; }
    public bool MobileUnlock_Tier_0_1 { get; set; }
    public bool MobileUnlock_Tier_0_1_Redeemed { get; set; }
    public bool MobileUnlock_Tier_0_2 { get; set; }
    public bool MobileUnlock_Tier_0_2_Redeemed { get; set; }
    public bool MobileUnlock_Tier_0_3 { get; set; }
    public bool MobileUnlock_Tier_0_3_Redeemed { get; set; }
    public bool MobileUnlock_Tier_0_4 { get; set; }
    public bool MobileUnlock_Tier_0_4_Redeemed { get; set; }
    public bool MobileUnlock_Tier_0_5 { get; set; }
    public bool MobileUnlock_Tier_0_5_Redeemed { get; set; }
    public bool MobileUnlock_Tier_0_6 { get; set; }
    public bool MobileUnlock_Tier_0_6_Redeemed { get; set; }
    public bool MobileUnlock_Tier_0_7 { get; set; }
    public bool MobileUnlock_Tier_0_7_Redeemed { get; set; }
    public bool MobileUnlock_Tier_1_1 { get; set; }
    public bool MobileUnlock_Tier_1_1_Redeemed { get; set; }
    public bool MobileUnlock_Tier_1_2 { get; set; }
    public bool MobileUnlock_Tier_1_2_Redeemed { get; set; }
    public bool MobileUnlock_Tier_1_3 { get; set; }
    public bool MobileUnlock_Tier_1_3_Redeemed { get; set; }
    public bool MobileUnlock_Tier_2_1 { get; set; }
    public bool MobileUnlock_Tier_2_1_Redeemed { get; set; }
    public bool MobileUnlock_Tier_2_2 { get; set; }
    public bool MobileUnlock_Tier_2_2_Redeemed { get; set; }
    public bool MobileUnlock_Tier_2_3 { get; set; }
    public bool MobileUnlock_Tier_2_3_Redeemed { get; set; }
    public bool MobileUnlock_Tier_3_1 { get; set; }
    public bool MobileUnlock_Tier_3_1_Redeemed { get; set; }
    public bool MobileUnlock_Tier_4_1 { get; set; }
    public bool MobileUnlock_Tier_4_1_Redeemed { get; set; }
    public bool MobileUnlock_Earth2DarkKnightAlt { get; set; }
    public int MouseSens { get; set; }
    public bool VoiceChat { get; set; }
    public bool PushToTalk { get; set; }
}

public class CustomSelection
{
    public string ArchetypeID { get; set; }
    public string LowerID { get; set; }
    public string UpperID { get; set; }
    public string FaceGearID { get; set; }
    public string HairID { get; set; }
    public string FacialHairID { get; set; }
    public string FacePaintID { get; set; }
    public string TattooID { get; set; }
    public string UndershirtID { get; set; }
    public int LowerSkinIdx { get; set; }
    public int UpperSkinIdx { get; set; }
    public int FaceGearSkinIdx { get; set; }
    public Dictionary<string, int> HairColor { get; set; }
    public Dictionary<string, int> FacialHairColor { get; set; }
    public bool bArchetypeIsGearPlus { get; set; }
    public bool bFaceGearIsGearPlus { get; set; }
    public bool bFacePaintIsGearPlus { get; set; }
    public bool bFacialHairIsGearPlus { get; set; }
    public bool bHairIsGearPlus { get; set; }
    public bool bLowerIsGearPlus { get; set; }
    public bool bTattooIsGearPlus { get; set; }
    public bool bUndershirtIsGearPlus { get; set; }
    public bool bUpperIsGearPlus { get; set; }
}

public class CustomConfigBank
{
    public List<CustomSelection> m_CustomSelection { get; set; }
}

public class CustomizationProfileData
{
    public int CustomProfileVersion { get; set; }
    public List<CustomConfigBank> CustomConfigBanks { get; set; }
    public List<int> CurrentSelectedCustomizationBank { get; set; }
    public List<int> LocalCharAltMeshIndex { get; set; }
}

public class LoadoutData
{
    public List<TeamData> TeamData { get; set; }
    public List<int> CurrentTeamBank { get; set; }
}

public class TeamData
{
    public List<TeamDataBank> Bank { get; set; }
}

public class TeamDataBank
{
    public int RelevantTeam { get; set; }
    public int EquippedWeapon { get; set; }
    public int WeaponSkinIdx { get; set; }
    public List<int> UnboundGadgets { get; set; }
    public List<int> DpadGadgets { get; set; }
    public List<int> QuickGadgets { get; set; }
    public List<int> DpadGadgetsUpgradeIdx { get; set; }
}

public class RecentUnlocks
{
    public TeamRecentUnlocks BaneTeamRecentUnlocks { get; set; }
    public TeamRecentUnlocks JokerTeamRecentUnlocks { get; set; }
    public List<string> WatchedVideoList { get; set; }
    public int NumVideos { get; set; }
}

public class TeamRecentUnlocks
{
    public Dictionary<string, AppearanceRecentUnlocks> AppearanceRecentUnlocks { get; set; }
}

public class AppearanceRecentUnlocks
{
    // Unknown data structure
}

public class MatchmakingData
{
    public int m_MaxHistoricalMatches { get; set; }
    public int m_RandomInitialValue { get; set; }
    public int MaxHistoricalBandwidthValues { get; set; }
}

public class WeaponScores
{
    public List<int> WeaponScore { get; set; }
    public List<int> MaxLifetimeWeaponScore { get; set; }
}
