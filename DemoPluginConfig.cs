using ShiroBot.SDK.Config;

namespace ShiroBot.Plugin.DemoPlugin;

public sealed class DemoPluginConfig
{
    [ConfigField("是否在启动时向主人发送问候消息")]
    public bool SendStartupHelloToOwner { get; set; } = true;
}
