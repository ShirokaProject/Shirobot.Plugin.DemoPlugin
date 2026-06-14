# ShiroBot DemoPlugin

ShiroBot 的示例插件，用于展示插件开发中的常见能力，例如好友/群命令、全局命令、消息回复订阅和事件处理。

## 功能示例

- 好友命令：`#help`、`#ping`、`#echo <内容>`
- 群命令：`#help`、`#ping`、`#echo <内容>`
- 群聊 @ 机器人、@ 全体成员、回复消息处理
- 全局命令：`#allcmd`
- 事件处理：消息撤回、好友请求、群成员增加
- 插件配置：`SendStartupHelloToOwner`

## 构建

```bash
dotnet publish
```

## Release 流程

仓库已配置 GitHub Actions 自动发布流程。

推送 `v*` 格式的 tag 会触发构建，并自动把插件自身的 DLL（排除 SDK/Model 等依赖）上传到对应的 GitHub Release。

示例：

```bash
git tag v1.0.0
git push origin v1.0.0
```
也可以在 GitHub Actions 页面手动运行 `Build Release` workflow，并填写要发布的 tag 名称。
