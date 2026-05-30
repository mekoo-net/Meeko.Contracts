# Meeko.Contracts

Meeko 跨服务 MagicOnion 契约：服务接口 + MessagePack DTO。

**消费方式**

- 作为 [meeko-platform](https://github.com/Nacho-Neko/meeko-platform) 的 git submodule（`src/Meeko.Contracts`）
- 或在独立仓库（如 ProxyGateway）中 submodule / `ProjectReference` 引用本仓库

**构建**

```bash
dotnet build Meeko.Contracts.slnx
```

**契约变更纪律**

- 禁止修改已有 `[Key(n)]` 编号（breaking change）
- 新字段只追加在最大 Key + 1
- 改 DTO 后同步升级所有引用方并一起部署
