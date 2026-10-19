using System.Threading.Tasks;
namespace TutorModule { public class FeatureUnlockManager { public static FeatureUnlockManager Instance { get; } = new(); public Task Init() => Env.Begin("FeatureUnlockManager"); } }
public class AudioManager { public static AudioManager Instance { get; } = new(); public Task Init() => Env.Begin("AudioManager"); }
namespace UIModuleO { public class UIHUDManager { public static UIHUDManager Instance { get; } = new(); public Task Init() => Env.Begin("UIHUDManager"); } }
namespace AssetsModule { public class EffectManager { public static EffectManager Instance { get; } = new(); public Task Init() => Env.Begin("EffectManager"); } }
namespace UIModuleO { public class UITextEffectManager { public static UITextEffectManager Instance { get; } = new(); public Task Init() => Env.Begin("UITextEffectManager"); } }
namespace AssetsModule { public class MaterialsManager { public static MaterialsManager Instance { get; } = new(); public Task Init() => Env.Begin("MaterialsManager"); } }
namespace GameModule { public class SteerManager { public static SteerManager Instance { get; } = new(); public Task Init() => Env.Begin("SteerManager"); } }
namespace GameModule { public class CheckStayGetRewardManager { public static CheckStayGetRewardManager Instance { get; } = new(); public Task Init() => Env.Begin("CheckStayGetRewardManager"); } }
namespace GameModule { public class ReportEventsManager { public static ReportEventsManager Instance { get; } = new(); public Task Init() => Env.Begin("ReportEventsManager"); } }
namespace GameModule { public class PanelPopHandleManager { public static PanelPopHandleManager Instance { get; } = new(); public Task Init() => Env.Begin("PanelPopHandleManager"); } }
namespace GameModule { public class PacksTipManager { public static PacksTipManager Instance { get; } = new(); public Task Init() => Env.Begin("PacksTipManager"); } }
namespace UIModuleO { public class PropDetailsManager { public static PropDetailsManager Instance { get; } = new(); public Task Init() => Env.Begin("PropDetailsManager"); } }
namespace SDKModule { public class AdButtonManager { public static AdButtonManager Instance { get; } = new(); public Task Init() => Env.Begin("AdButtonManager"); } }
public class AnnouncementManager { public static AnnouncementManager Instance { get; } = new(); public Task Init() => Env.Begin("AnnouncementManager"); }
namespace GameModule { public class ResourceObtainGuideManager { public static ResourceObtainGuideManager Instance { get; } = new(); public Task Init() => Env.Begin("ResourceObtainGuideManager"); } }
public class CheckInRewardManager { public static CheckInRewardManager Instance { get; } = new(); public Task Init() => Env.Begin("CheckInRewardManager"); }
namespace GameModule { public class SubGameChaosTrailsManager { public static SubGameChaosTrailsManager Instance { get; } = new(); public Task Init() => Env.Begin("SubGameChaosTrailsManager"); } }
namespace GameModule { public class UserResourcesManager { public static UserResourcesManager Instance { get; } = new(); public Task Init() => Env.Begin("UserResourcesManager"); } }
namespace CameraModule { public class CameraManager { public static CameraManager Instance { get; } = new(); public Task Init() => Env.Begin("CameraManager"); } }
namespace GameModule { public class GameManager { public static GameManager Instance { get; } = new(); public Task Init() => Env.Begin("GameManager"); } }
namespace SDKModule { public class HWIAPManager { public static HWIAPManager Instance { get; } = new(); public Task Init() => Env.Begin("HWIAPManager"); } }
namespace GameConfigModule { public class GameConfigManager { public static GameConfigManager Instance { get; } = new(); public Task Init() => Env.Begin("GameConfigManager"); } }